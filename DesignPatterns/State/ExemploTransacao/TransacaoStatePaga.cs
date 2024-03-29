namespace State.ExemploTransacao;

public class TransacaoStatePaga : TransacaoState
{
    public override void Cobrar()
    {
        Console.WriteLine("Transação já foi cobrada e está paga!");
    }

    public override void Estornar()
    {
        Console.WriteLine("Transação estornada!");
        Contexto.AlterarState(new TransacaoStateEstornada());
    }

    public override void ImprimirComprovante()
    {
        Console.WriteLine("Comprovante: **Transação Paga**");
    }
}
