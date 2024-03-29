namespace FactoryMethod.Pix;

public class CriadorPixEstatico : FabricaTransacaoPix
{
    public override TransacaoPix CriarTransacao()
        => new TransacaoPixEstatico();
}
