namespace Builder;

public class CasaDeLuxoBuilder : ICasaBuilder
{
    private Casa _casa;

    public CasaDeLuxoBuilder()
    {
        _casa = new Casa();
    }

    public Casa Build()
        => _casa;

    public Casa ConstruirCasa()
        => _casa;

    public ICasaBuilder DefinirPiscina()
    {
        IPiscina piscina = new PiscinaOlimpica();
        _casa.Piscina = piscina;
        return this;
    }

    public ICasaBuilder DefinirPorta()
    {
        IPorta porta = new PortaDeMadeira();
        _casa.Porta = porta;
        return this;
    }

    public ICasaBuilder DefinirQuintal()
    {
        IQuintal quintal = new QuintalComGrama();
        _casa.Quintal = quintal;
        return this;
    }
}
