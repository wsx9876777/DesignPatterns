using System;
using System.Collections.Generic;
using System.Text;

namespace interpreter.Concrete
{
    class Context
    {
		private string _output;
		public string output
		{
			get { return _output; }
			set { _output = value; }
		}

		private string _input;
		public string input
		{
			get { return _input; }
			set { _input = value; }
		}
		public Context(string str)
		{
			_input = str;
		}
	}
}
