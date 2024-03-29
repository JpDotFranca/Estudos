namespace FactoryMethod.Pix;

public class TransacaoPixDinamico : TransacaoPix
{
    public string CriarQrCode(int valorPix)
        => "Copia e cola pix dinamico!";
}
