using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.Model
{
    class Memento
    {
        private string _statement;

        public string Text
        {
            get { return _statement; }
        }

        public Memento(string text)
        {
            _statement = text;
        }
    }
}
