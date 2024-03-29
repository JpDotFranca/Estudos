using State.ExemploSmartphone;
using State.ExemploTransacao;

namespace State;

public class Program
{
    static void Main(string[] args)
    {
        #region Exemplo do telefone

        ISmartphone motorolaTijolao = new Smartphone();

        motorolaTijolao.QuandoBotaoVolumeAcionado();
        motorolaTijolao.QuandoBotaoHomeAcionado();
        motorolaTijolao.QuandoBotaoHomeAcionado();
        motorolaTijolao.QuandoBotaoLigarDesligarForAcionado();

        motorolaTijolao.QuandoBotaoVolumeAcionado();
        motorolaTijolao.QuandoBotaoHomeAcionado();
        motorolaTijolao.QuandoBotaoHomeAcionado();
        motorolaTijolao.QuandoBotaoVolumeAcionado();
        motorolaTijolao.QuandoBotaoHomeAcionado();
        motorolaTijolao.QuandoBotaoHomeAcionado();
        motorolaTijolao.QuandoBotaoLigarDesligarForAcionado();

        motorolaTijolao.QuandoBotaoVolumeAcionado();
        motorolaTijolao.QuandoBotaoHomeAcionado();
        motorolaTijolao.QuandoBotaoHomeAcionado();

        #endregion

        Console.Clear();

        #region Exemplo de status de transação

        ITransacao transacaoDeAltCoin = new Transacao();
        transacaoDeAltCoin.ImprimirComprovante();
        transacaoDeAltCoin.Estornar();
        transacaoDeAltCoin.Cobrar();

        transacaoDeAltCoin.ImprimirComprovante();
        transacaoDeAltCoin.Cobrar();
        transacaoDeAltCoin.Estornar();

        transacaoDeAltCoin.ImprimirComprovante();
        transacaoDeAltCoin.Cobrar();
        transacaoDeAltCoin.Estornar();
        transacaoDeAltCoin.ImprimirComprovante();

        #endregion
    }
}
