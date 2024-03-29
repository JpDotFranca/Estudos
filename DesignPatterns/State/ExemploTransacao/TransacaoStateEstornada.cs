namespace State.ExemploTransacao;

public class TransacaoStateEstornada : TransacaoState
{
    public override void Cobrar()
    {
        Console.WriteLine("Transação já foi paga e estornada!");
    }

    public override void Estornar()
    {
        Console.WriteLine("Transação já foi estornada!");
    }

    public override void ImprimirComprovante()
    {
        Console.WriteLine("Comprovante: **Transação Estornada**");
    }
}