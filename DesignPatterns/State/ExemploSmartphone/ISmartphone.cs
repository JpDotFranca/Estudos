namespace State.ExemploSmartphone;

public interface ISmartphone
{
    void QuandoBotaoHomeAcionado();
    void QuandoBotaoVolumeAcionado();
    void QuandoBotaoLigarDesligarForAcionado();
    void MudarEstado(State state);
}
