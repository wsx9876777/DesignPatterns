using interpreter.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace interpreter.Concrete
{
    class ProtectorLayerOne : IContextProtector
    {
        public override void Dencrypt(Context context)
        {
            context.input = context.output = context.output.Replace(" ProtectorLayerOne", "");
        }

        public override void Encrypt(Context context)
        {
            context.input = context.output = 
                context.input + " ProtectorLayerOne";
        }
    }
}
