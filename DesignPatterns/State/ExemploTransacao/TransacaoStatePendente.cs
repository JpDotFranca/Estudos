namespace State.ExemploTransacao;

public class TransacaoStatePendente : TransacaoState
{
    public override void Cobrar()
    {
        Console.WriteLine("Transação paga com sucesso!");
        Contexto.AlterarState(new TransacaoStatePaga());
    }

    public override void Estornar()
    {
        Console.WriteLine("Transação nem foi paga ainda! Não é possivel estornar!");
    }

    public override void ImprimirComprovante()
    {
        Console.WriteLine("Comprovante: **Transação Pendente**");
    }
}
