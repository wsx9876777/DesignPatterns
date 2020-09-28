using System;
using System.Collections.Generic;
using System.Text;

namespace Template.Hnadler
{
    abstract class DocumentHandler
    {
        public abstract void DownloadDoc();
        public abstract void UnzipDoc();
        public abstract void ReadDoc();
        public void Handle()
        {
            DownloadDoc();
            UnzipDoc();
            ReadDoc();
        }
    }
}
