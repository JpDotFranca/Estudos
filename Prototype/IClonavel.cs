using Newtonsoft.Json;

namespace Prototype
{
    public interface IClonavel<T> where T : class
    { 
        public T Clone();
    }
}
