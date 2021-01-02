using Adapter.Interface;
using System.Net;

namespace Adapter.Adapter
{
    class JsonReaderAdapter : ITarget
    {
        public JsonReaderAdapter(string path)
        {
            
        }

        public T ReadJson<T>() where T:new()
        {
            return new T();
        }

    }
}
