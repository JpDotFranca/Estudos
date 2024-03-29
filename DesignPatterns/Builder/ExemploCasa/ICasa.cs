namespace Builder;

public interface ICasa
{
    IPiscina Piscina { get; protected set; }
    IQuintal Quintal { get; protected set; }
    IPorta Porta { get; protected set; }
}
