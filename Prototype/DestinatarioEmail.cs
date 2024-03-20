/* 
 * O pardrão prototype tem o intuito de padronizar a forma com que os objetos são clonados a partir de outros.
*/

namespace Prototype;

public class DestinatarioEmail: IClonavel<DestinatarioEmail>
{
    public string Email { get; set; }

    public DestinatarioEmail Clone()
    {
        DestinatarioEmail clone = new();
        clone.Email = Email;
        return clone;
    }
}
