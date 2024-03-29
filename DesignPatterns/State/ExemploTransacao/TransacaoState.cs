namespace State.ExemploTransacao;

public abstract class TransacaoState : ITransacao
{
    protected ITransacao Contexto;

    public void AlterarState(TransacaoState state)
    {
        Contexto.AlterarState(state);
    }

    public abstract void Cobrar();
    public abstract void Estornar();
    public abstract void ImprimirComprovante();

    internal void AlterarContexto(ITransacao contexto)
    {
        Contexto = contexto;
    }
}
