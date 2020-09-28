using Builder.Builder;
using Builder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Factory
{
    interface INotebookFactory
    {
        NoteBook Build(NotebookBuilderAbstractor notebookBuilderAbstractor);
    }
}
