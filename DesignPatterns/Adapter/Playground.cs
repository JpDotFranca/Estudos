using System.Globalization;

namespace Adapter
{
    public class Playground
    {
        // ADAPTER TAMBÉM CONHECIDO COMO WRAPPER.

        // O QUE O PADRÃO RESOLVE?

        /* Ele resolve a adaptação entre uma implementação com entradas diferentes em um contexto onde já há várias
         * entradas já padronizadas e em funcionamento.*/

        // COMO ELE RESOLVE?
        /* Resolve criando um objeto especial que concentra a lógica de converter a entrada diferente para a entrada que 
         * já é conhecida pelo contexto. */

        // QUAIS AS VANTAGENS?
        /* Atende ao 'S' do SOLID quando separa o objeto do Adapter da lógica já existente;
         * Atende ao 'O' do SOLID quando introduz novos tipos sem quebrar o código existente.*/

        // QUAIS AS DESVANTAGENS?
        /* Adiciona bastante complexidade pelo fato de fazer uma estrutura que se adapte.
         * Se for possível, é preferível apenas alterar a forma com que a leitura é feita. */

        // QUANDO UTILIZAR?
        /* Quando precisa usar alguma classe que tenha a interface incompatível com o código existente. */

        // OUTRAS MANEIRAS DE RESOLVER O PROBLEMA?
        /* Mapper. Decorator */

        #region Exemplo 1

        public interface IConversorComprovante_Tipo990
        {
            ComprovantePagamento_Tipo990 Converter(string linhaArquivo);
        }
        public class ConversorComprovante_Tipo990 : IConversorComprovante_Tipo990
        {
            private static ConversorComprovante_Tipo990 _instancia;
            public static ConversorComprovante_Tipo990 Instancia
            {
                get
                {
                    if (_instancia == null)
                        _instancia = new ConversorComprovante_Tipo990();
                    return _instancia;
                }
            }

            public ComprovantePagamento_Tipo990 Converter(string linhaArquivo)
            {
                List<string> valores = linhaArquivo.Split('|').ToList();

                ComprovantePagamento_Tipo990 novoComprovante = new()
                {
                    DataPagamento = DateOnly.ParseExact(valores[0], "yyyyMMdd", CultureInfo.InvariantCulture),
                    Valor = decimal.Parse(valores[1]),
                    Email = valores[2],
                    NomePagador = valores[3],
                };
                return novoComprovante;
            }
        }
        public class ComprovantePagamento_Tipo990
        {
            public DateOnly DataPagamento { get; set; }
            public decimal Valor { get; set; }
            public string NomePagador { get; set; }
            public string Email { get; set; }
        }
        public class ServicoProcessamentoPagamento
        {
            public IConversorComprovante_Tipo990 _conversor;
            public ServicoProcessamentoPagamento(IConversorComprovante_Tipo990 conversor)
            {
                _conversor = conversor;
            }

            public void ProcessarPagamento(string stringComprovante)
            {
                ComprovantePagamento_Tipo990 comprovante = _conversor.Converter(stringComprovante);
                Console.WriteLine($"Pagamento de R${comprovante.Valor} processado com sucesso pelo {comprovante.NomePagador} em {comprovante.DataPagamento}!");
            }
        }
        public class ServicoEmail
        {
            private IConversorComprovante_Tipo990 _conversor;
            public ServicoEmail(IConversorComprovante_Tipo990 conversor)
            {
                _conversor = conversor;
            }

            public void EnviarEmail(string stringComprovante)
            {
                ComprovantePagamento_Tipo990 comprovante = _conversor.Converter(stringComprovante);
                Console.WriteLine($"E-mail de pagamento enviado com sucesso para {comprovante.NomePagador} no endereço {comprovante.Email}!");
            }
        }

        #endregion

        static void Main(string[] args)
        {
            //     {data de pagamento}|{valor pago}|{nome do pagador}|{email pagador}
            string valorPago_1 = $"20231015|15.18|Amado Carraro|amado.car@hotmail.com";
            string valorPago_2 = $"20231014|78.17|Mirosmindo Antonieti|miro.antonieti@msn.com";
            string valorPago_3 = $"20230212|35.07|Gilnisclei Cairú|gilni.iru@bol.com";

            IConversorComprovante_Tipo990 conversor = new ConversorComprovante_Tipo990();
            ServicoProcessamentoPagamento servicoProcessamento = new(conversor);
            ServicoEmail servicoEmail = new(conversor);

            servicoProcessamento.ProcessarPagamento(valorPago_1);
            servicoEmail.EnviarEmail(valorPago_1);
            Console.WriteLine();

            servicoProcessamento.ProcessarPagamento(valorPago_2);
            servicoEmail.EnviarEmail(valorPago_2);
            Console.WriteLine();

            servicoProcessamento.ProcessarPagamento(valorPago_3);
            servicoEmail.EnviarEmail(valorPago_3);
            Console.WriteLine();


            #region O problema e a solução com adapter

            /* É preciso agora ler os arquivos em outro formato para alimentar o sistema que já processa 
             * o pagamento e envia o e-mail*/

            //     {data de pagamento}|{nome do pagador}|{email pagador}|{valor desconto}|{valor pago}
            string valorPago_4 = $"20231015|Amado Carraro|amado.car@hotmail.com|3|15.18";
            string valorPago_5 = $"20231014|Mirosmindo Antonieti|miro.antonieti@msn.com|15|78.17";
            string valorPago_6 = $"20230212|Gilnisclei Cairú|gilni.iru@bol.com|0|35.07";

            IConversorComprovante_Tipo990 conversorAdaptado = new ConversorComprovanteAdaptado_Tipo990();

            servicoProcessamento = new(conversorAdaptado);
            servicoEmail = new(conversorAdaptado);

            servicoProcessamento.ProcessarPagamento(valorPago_4);
            servicoEmail.EnviarEmail(valorPago_4);
            Console.WriteLine();

            servicoProcessamento.ProcessarPagamento(valorPago_5);
            servicoEmail.EnviarEmail(valorPago_5);
            Console.WriteLine();

            servicoProcessamento.ProcessarPagamento(valorPago_6);
            servicoEmail.EnviarEmail(valorPago_6);
            Console.WriteLine();
            #endregion
        }
        public class ConversorComprovanteAdaptado_Tipo990 : IConversorComprovante_Tipo990
        {
            public ComprovantePagamento_Tipo990 Converter(string linhaArquivo)
            {
                List<string> valores = linhaArquivo.Split('|').ToList();

                ComprovantePagamento_Tipo990 novoComprovante = new()
                {
                    DataPagamento = DateOnly.ParseExact(valores[0], "yyyyMMdd", CultureInfo.InvariantCulture),
                    NomePagador = valores[1],
                    Email = valores[2],
                    Valor = decimal.Parse(valores[4])
                };
                return novoComprovante;
            }
        }
    }
}