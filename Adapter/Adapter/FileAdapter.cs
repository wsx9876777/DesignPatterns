using Adapter.Interface;
using Adapter.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Adapter.Adapter
{
    class FileAdapter : FileStream
    {
        public FileAdapter(string path):base(path, FileMode.Open)
        {

        }
        public T ReadJson<T>()
        {

            byte[] buffer = new byte[64];
            StringBuilder sb = new StringBuilder();
            string str;
            string tmp;
            int len = (int)base.Length;
            while (len > 0)
            {
                if (len< buffer.Length)
                {
                    buffer = new byte[len];
                }
                len = len - Read(buffer, 0,buffer.Length);
                
                
                tmp = Encoding.UTF8.GetString(buffer)
                    .Replace(" ", "")
                    .Replace("\r", "")
                    .Replace("\n", "");
                sb.Append(tmp);
            }
            base.Dispose();
            str = sb.ToString();
            var  options = new JsonSerializerOptions();
            options.PropertyNameCaseInsensitive = true;
            //options.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));
         
            var obj = JsonSerializer.Deserialize<T>(str, options);
            return obj;
        }
    }
}
