using Builder.Builder;
using Builder.Factory;
using Builder.Models;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            NotebookBuilderAbstractor zenbookBuilder = new ZenbookBuilder();
            INotebookFactory NotebookFactory = new NotebookFactory();
            NoteBook noteBook = NotebookFactory.Build(zenbookBuilder);
            Console.WriteLine(noteBook.Price);

        }
    }
}
