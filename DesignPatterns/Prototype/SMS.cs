/* 
 * O pardrão prototype tem o intuito de padronizar a forma com que os objetos são clonados a partir de outros.
*/

namespace Prototype;

public class SMS : IClonavel<SMS>, IMensagem
{
    public DateTime DataEnvio { get; set; }
    public string Mensagem { get; set; }
    public DestinatarioSMS Destinatario { get; set; }
    public List<DestinatarioSMS> Destinatarios { get; set; }

    public SMS Clone()
    {
        SMS clone = new();
        clone.DataEnvio = DataEnvio;
        clone.Mensagem = Mensagem;
        clone.Destinatario = Destinatario.Clone();
        clone.Destinatarios = Destinatarios.Select(d=> d.Clone()).ToList();

        return clone;
    }
}
