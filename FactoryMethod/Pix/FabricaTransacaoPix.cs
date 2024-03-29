namespace FactoryMethod.Pix;

public abstract class FabricaTransacaoPix : TransacaoPix
{
    public abstract TransacaoPix CriarTransacao();

    public string CriarQrCode(int valorPix)
    {
        TransacaoPix transacao = CriarTransacao();
        return transacao.CriarQrCode(valorPix);
    }
}
