/* 
 * O pardrão prototype tem o intuito de padronizar a forma com que os objetos são clonados a partir de outros.
*/

namespace Prototype;

public class Email : IClonavel<Email>, IMensagem
{
    public DateTime DataEnvio { get; set; }
    public string Mensagem { get; set; }
    public DestinatarioEmail Destinatario { get; set; }

    public Email Clone()
    {
        Email clone = new Email();
        clone.DataEnvio = DataEnvio;
        clone.Mensagem = Mensagem;
        clone.Destinatario = Destinatario.Clone();

        return clone;
    }
}
