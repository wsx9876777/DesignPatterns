using Builder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Builder
{
    abstract class NotebookBuilderAbstractor
    {
        protected readonly NoteBook _noteBook;
        public NotebookBuilderAbstractor()
        {
            _noteBook = new NoteBook();
        }
        public NotebookBuilderAbstractor(NoteBook noteBook)
        {
            _noteBook = noteBook;
        }
        public abstract void SetName();
        public abstract void SetPrice();
        public NoteBook GetNoteBook() => _noteBook;
    }
}
