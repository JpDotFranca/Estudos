namespace Builder.Casa.Casa;

public class CasaSimplesBuilder : ICasaBuilder
{
    private Casa _casa;

    public CasaSimplesBuilder()
    {
        _casa = new Casa();
    }

    public Casa Build()
    {
        return _casa;
    }

    public ICasaBuilder DefinirPiscina()
    {
        _casa.Piscina = null;
        return this;
    }

    public ICasaBuilder DefinirPorta()
    {
        _casa.Porta = new PortaDeFerro();
        return this;
    }

    public ICasaBuilder DefinirQuintal()
    {
        _casa.Quintal = new QuintalComPiso();
        return this;
    }
}
