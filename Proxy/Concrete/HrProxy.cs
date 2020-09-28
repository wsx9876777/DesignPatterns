using Proxy.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Concrete
{
    class HrProxy : HrAuth, IHumenResource
    {
        private readonly Leave leave = new Leave();
        public HrProxy(string name,string pass):base (name,pass)
        {

        }
        public bool Apply()
        {
            if (IsLegle())
            {
               return leave.Apply();
            }
            throw new Exception("Not Legle");
           
        }

        public bool IsEligible()
        {
            if (IsLegle())
            {
                return leave.IsEligible();
            }
            throw new Exception("Not Legle");
        }

        public bool Reject()
        {
            if (IsLegle())
            {
                return leave.Reject();
            }
            throw new Exception("Not Legle");
        }
    }
}
