using Command.Handler;
using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Interface
{
    abstract class ICommand
    {
        public abstract Calculator Execute();
        public abstract Calculator UnExecute();
    }
}
