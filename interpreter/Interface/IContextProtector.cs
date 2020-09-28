using interpreter.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace interpreter.Interface
{
    abstract class IContextProtector
    {
        public abstract void Encrypt(Context context);
        public abstract void Dencrypt(Context context);
    }
}
