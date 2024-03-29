namespace Builder.Casa.Casa;

public sealed class CriadorCasas
{
    private readonly ICasaBuilder _casaBuilder;

    public CriadorCasas(ICasaBuilder casaBuilder)
    {
        _casaBuilder = casaBuilder;
    }

    public void MontarCasa()
    {
        _casaBuilder.DefinirPiscina()
                    .DefinirPorta()
                    .DefinirQuintal();
    }

    public Casa Build()
    {
        return _casaBuilder.Build();
    }
}