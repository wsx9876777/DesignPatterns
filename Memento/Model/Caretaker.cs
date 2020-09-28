using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.Model
{
    class Caretaker
    {
        List<Memento> _mementos = new List<Memento>();

        public void AddMemento(Memento memento) => _mementos.Add(memento);
        public Memento this[int idx]
        {
            get {
                if (idx > -1 && idx < _mementos.Count)
                {
                    return _mementos[idx];
                }
                return null;
            }
        }
       
        public int Count => _mementos.Count;
    }
}
