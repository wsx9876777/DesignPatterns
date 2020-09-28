using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.Model
{
    class Originator
    {
		private string _text;

		public string Text
		{
			get { return _text; }
			set { _text = value; }
		}
		public Memento StoreInMemento()
		{
			return new Memento(_text);
		}
		public string GetFromMemento(Memento memento)
		{
			return memento.Text;
		}
	}
}
