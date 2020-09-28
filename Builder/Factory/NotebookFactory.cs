using Builder.Builder;
using Builder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Factory
{
    class NotebookFactory : INotebookFactory
    {
        public NoteBook Build(NotebookBuilderAbstractor notebookBuilderAbstractor)
        {
            notebookBuilderAbstractor.SetPrice();
            notebookBuilderAbstractor.SetName();

            return notebookBuilderAbstractor.GetNoteBook();
        }
    }
}
