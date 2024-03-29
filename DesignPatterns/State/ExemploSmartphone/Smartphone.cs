namespace State.ExemploSmartphone;

public class Smartphone : ISmartphone
{
    private State _state;

    public Smartphone()
    {
        _state = new LigadoState(this);
    }

    public void MudarEstado(State state)
    {
        _state = state;
    }

    public void QuandoBotaoHomeAcionado()
    {
        _state.QuandoBotaoHomeAcionado();
    }

    public void QuandoBotaoLigarDesligarForAcionado()
    {
        _state.QuandoBotaoLigarDesligarForAcionado();
    }

    public void QuandoBotaoVolumeAcionado()
    {
        _state.QuandoBotaoVolumeAcionado();
    }
}
