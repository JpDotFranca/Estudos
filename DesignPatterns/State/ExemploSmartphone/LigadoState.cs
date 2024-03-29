namespace State.ExemploSmartphone;

public class LigadoState : State
{
    public LigadoState(ISmartphone smartphone)
        : base(smartphone) { }

    public override void MudarEstado(State state)
    {
        Contexto.MudarEstado(state);
    }

    public override void QuandoBotaoHomeAcionado()
    {
        Console.WriteLine("Está na tela Home!");
    }

    public override void QuandoBotaoLigarDesligarForAcionado()
    {
        Console.WriteLine("Desligando o telefone. !Hello, Moto!");
        Contexto.MudarEstado(new DesligadoState(Contexto));
    }

    public override void QuandoBotaoVolumeAcionado()
    {
        Console.WriteLine("Volume alterado!");
    }
}
