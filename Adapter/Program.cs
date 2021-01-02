using Adapter.Adapter;
using Adapter.Adapter.ConcreteClass;
using Adapter.Interface;
using Adapter.Models;
using System;
using System.Data.Common;
using System.IO;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //利用adapter模式，避免需更動所有直接依賴的物件，
            //只需更改被轉接的物件，不用動到adapter的實例後的程式。
            string path = @"D:\LinkedinLearning\DesignPatten\DesginPattern\Adapter\MyJson.json";
            bool bol = File.Exists(path);
            var adapter = new JsonReaderAdapter(path);
            var data = adapter.ReadJson<Exclude>();

        }
    }
}
