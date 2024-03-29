namespace Builder;

public class Casa : ICasa
{
    public IPiscina Piscina { get; set; }
    public IQuintal Quintal { get; set; }
    public IPorta Porta { get; set; }
}
