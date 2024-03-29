/* 
 * O pardrão prototype tem o intuito de padronizar a forma com que os objetos são clonados a partir de outros.
*/

namespace Prototype;

public interface IMensagem
{
    public DateTime DataEnvio { get; set; }
    public string Mensagem { get; set; }
}
