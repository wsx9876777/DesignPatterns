using interpreter.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace interpreter.Concrete
{
    class ProtectorLayerTwo : IContextProtector
    {
        public override void Dencrypt(Context context)
        {
            context.input = context.output = context.output.Replace(" ProtectorLayerTwo","");
        }

        public override void Encrypt(Context context)
        {
            context.input = context.output 
                = context.input +  " ProtectorLayerTwo";
        }
    }
}
