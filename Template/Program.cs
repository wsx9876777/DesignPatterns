using System;
using Template.Hnadler;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentHandler DocHandler = new EconomicDocumentHandler();
            DocHandler.Handle();
        }
    }
}
