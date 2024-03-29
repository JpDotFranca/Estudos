namespace FactoryMethod.Pix;

public class CriadorPixDinamico : FabricaTransacaoPix
{
    public override TransacaoPix CriarTransacao()
        => new TransacaoPixDinamico();
}
