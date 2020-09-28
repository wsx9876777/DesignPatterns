using System;
using System.Collections.Generic;
using System.Text;

namespace Template.Hnadler
{
    class EconomicDocumentHandler : DocumentHandler
    {
        public override void DownloadDoc()
        {
            Console.WriteLine("Download Economic Doc");
        }

        public override void ReadDoc()
        {
            Console.WriteLine("Read Economic Doc");
        }

        public override void UnzipDoc()
        {
            Console.WriteLine("Unzip Economic Doc");
        }
    }
}
