namespace State.ExemploTransacao;

public interface ITransacao
{
    public void Cobrar();
    public void Estornar();
    public void ImprimirComprovante();
    public void AlterarState(TransacaoState state);
}
