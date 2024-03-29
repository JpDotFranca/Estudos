namespace FactoryMethod.Pix;

public class TransacaoPixEstatico : TransacaoPix
{
    public string CriarQrCode(int valorPix)
        => "Copia e cola pix estatico!";
}