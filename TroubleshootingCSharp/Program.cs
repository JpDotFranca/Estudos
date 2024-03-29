
using System.Diagnostics;
using System.Runtime.InteropServices;

INICIO:
Stopwatch sw = new();
List<eCPF> valor = new List<eCPF>(1_000_000); 

sw.Start();
for (int i = 0; i < 1_000_000; i++)
{
    valor.Add(new eCPF(i.ToString()));
    //valor.Add(new CPF(i.ToString()));
}
sw.Stop();
Console.WriteLine("t: " + Marshal.SizeOf(valor));
Console.WriteLine("Tempo: " + sw.ElapsedMilliseconds + "ms");
Console.WriteLine("G0: " + GC.CollectionCount(0));
Console.WriteLine("G1: " + GC.CollectionCount(1));
Console.WriteLine("G2: " + GC.CollectionCount(2));
Console.WriteLine("*****************************");

Thread.Sleep(1000);
Console.ReadKey();
//goto INICIO;

public record struct eCPF
{
    public string Valor { get; set; }

    public eCPF(string valor)
    {
        Valor = valor;
    }
}

public class CPF
{
    public CPF()
    { }

    public CPF(string valor)
    {
        Valor = valor;
    }
    public string Valor { get; set; }
}