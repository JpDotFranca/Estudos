namespace Builder.Casa.Casa;

/*
 * O objetivo do padrão builder é facilitar a criação de objetos complexos de forma organizada.
 * Ele nos leva a criar objetos diferentes usando o mesmo padrão de construção.
 * No fim das contas ele sempre criará o objeto com base na mesma classe porém com as suas propriedades com valores diferentes.
 * Ela evita que a criação do objetocontenha uma infinidade de parâmetros no construtor.
 */

public class Program
{
    static void Main(string[] args)
    {
        #region Exemplo com Notebooks
        // Abordagem convencional 

        /// <summary>
        /// Podemos notar que na criação do MAC, omitimos o valor para a placa de vídeo pois o modelo não possui.
        /// A alternativa seria criar mais um construtor para o objeto ignorando a condição ou fazer um tipo especialista que
        /// herdasse de macbook. Aí que vem a alternativa do Builder. 
        /// </summary>
        Notebook macBook = new("Apple", "Air", 2015, null, 16, "ssd");
        Notebook acer = new("Acer", "ASPIRE", 2020, "RTX 4060", 64, "ssd");

        // Abordagem com builder
        INotebookBuilder aspireBuilder = new AspireBuilder().DefinirAnoFabricacao(2020)
                                                            .DefinirModeloPlacaVideo("RTX 4070")
                                                            .DefinirGBMemoriaRam(1500);

        Notebook acer_com_builder = aspireBuilder.Build();
        #endregion

        #region Exemplo com casas

        ICasaBuilder casaLuxoBuilder = new CasaDeLuxoBuilder();
        CriadorCasas criadorCasas = new(casaLuxoBuilder);

        criadorCasas.MontarCasa();
        Casa casaLuxo = criadorCasas.Build();

        criadorCasas.MontarCasa();
        criadorCasas = new(new CasaSimplesBuilder());
        Casa casaSimples = criadorCasas.Build();

        #endregion
    }
}
