/* 
 * O pardrão prototype tem o intuito de padronizar a forma com que os objetos são clonados a partir de outros.
*/

namespace Prototype;

public class DestinatarioSMS: IClonavel<DestinatarioSMS>
{
    public int DDD { get; set; }
    public int NumeroCelular { get; set; }

    public DestinatarioSMS Clone()
    {
        DestinatarioSMS clone = new();
        clone.NumeroCelular = this.NumeroCelular;
        return clone;
    }
}
