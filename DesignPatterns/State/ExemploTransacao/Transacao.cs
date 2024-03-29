namespace State.ExemploTransacao;

public class Transacao : ITransacao
{
    public Transacao()
    {
        AlterarState(new TransacaoStatePendente());
    }

    private TransacaoState _state;
    public void AlterarState(TransacaoState state)
    {
        _state = state;
        _state.AlterarContexto(this);
    }

    public void Cobrar()
    {
        _state.Cobrar();
    }

    public void Estornar()
    {
        _state.Estornar();
    }

    public void ImprimirComprovante()
    {
        _state.ImprimirComprovante();
    }
}
