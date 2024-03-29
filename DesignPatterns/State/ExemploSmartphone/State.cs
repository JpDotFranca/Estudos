namespace State.ExemploSmartphone;

public abstract class State : ISmartphone
{
    protected ISmartphone Contexto;
    protected State(ISmartphone smartphone)
    {
        Contexto = smartphone;
    }

    public abstract void MudarEstado(State state);
    public abstract void QuandoBotaoHomeAcionado();
    public abstract void QuandoBotaoLigarDesligarForAcionado();
    public abstract void QuandoBotaoVolumeAcionado();
}
