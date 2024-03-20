/* 
 * O pardrão prototype tem o intuito de padronizar a forma com que os objetos são clonados.
 * 
 * Falando de C#, já sabemos que o ShallowCopy faz apenas cópias rasas.
 * Nessa implementação, seguindo o prototype, se parte do princípio que para objetos com propriedades
 * que possuem valores de referência, deve se implementar também o padrão IClonavel.
*/

namespace Prototype;

public class Program
{
    static void Main(string[] args)
    {
        SMS sms = new();
        sms.Destinatario = new DestinatarioSMS();
        sms.Destinatario.NumeroCelular = 999999999;
        sms.Destinatario.DDD = 51;
        sms.DataEnvio = DateTime.Now;
        sms.Mensagem = "Hello, SMS!";
        sms.Destinatarios = new();
        DestinatarioSMS destinatario1 = new();
        destinatario1.DDD = 53; // Perceba que esse valor não muda após o clone
        destinatario1.NumeroCelular = 5555555;
        sms.Destinatarios.Add(destinatario1);

        SMS copiaSms = sms.Clone();
        copiaSms.Destinatarios[0].DDD = 35;
    }
}
