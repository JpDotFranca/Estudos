namespace FactoryMethod;

public class Program
{
    static void Main(string[] args)
    {
        TransacaoPix transacao = new CriadorPixDinamico();
        transacao.CriarQrCode(14);
    }
}

public abstract class FabricaTransacaoPix : TransacaoPix
{
    public abstract TransacaoPix CriarTransacao();

    public string CriarQrCode(int valorPix)
    {
       TransacaoPix transacao = CriarTransacao();
        return transacao.CriarQrCode(valorPix);
    }
}

public class CriadorPixDinamico : FabricaTransacaoPix
{
    public override TransacaoPix CriarTransacao()
        => new TransacaoPixDinamico();
}

public class CriadorPixEstatico : FabricaTransacaoPix
{
    public override TransacaoPix CriarTransacao()
        => new TransacaoPixEstatico();
}

public interface TransacaoPix
{
    string CriarQrCode(int valorPix);
}

public class TransacaoPixDinamico : TransacaoPix
{
    public string CriarQrCode(int valorPix)
        => "Copia e cola pix dinamico!";
}

public class TransacaoPixEstatico : TransacaoPix
{
    public string CriarQrCode(int valorPix)
        => "Copia e cola pix estatico!";
}