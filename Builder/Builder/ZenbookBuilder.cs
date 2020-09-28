using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Builder
{
    class ZenbookBuilder : NotebookBuilderAbstractor
    {
        public override void SetName()
        {
            base._noteBook.Name = "Zenbook";
        }
        public override void SetPrice()
        {
            base._noteBook.Price = 45000.10m;
        }
    }
}
