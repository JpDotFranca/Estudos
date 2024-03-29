namespace State.ExemploSmartphone;

public class DesligadoState : State
{
    public DesligadoState(ISmartphone smartphone)
        : base(smartphone) { }

    public override void MudarEstado(State state)
        => Contexto.MudarEstado(state);

    public override void QuandoBotaoHomeAcionado()
    {
        Console.WriteLine("Nada aconteceu. Telefone desligado!");
    }

    public override void QuandoBotaoLigarDesligarForAcionado()
    {
        Console.WriteLine("Ligando telefone. Hello, Moto!");
        Contexto.MudarEstado(new LigadoState(Contexto));
    }

    public override void QuandoBotaoVolumeAcionado()
    {
        Console.WriteLine("Nada aconteceu. Telefone desligado!");
    }
}