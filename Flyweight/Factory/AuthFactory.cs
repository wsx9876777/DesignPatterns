using Flyweight.Concrete;
using Flyweight.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight.Factory
{
    class AuthFactory
    {
        Dictionary<string, IAuthiorize> AuthList = new Dictionary<string, IAuthiorize>();
        public IAuthiorize GetAtuh(string name)
        {
            if (!AuthList.ContainsKey(name))
            { 
                AuthList[name] = name switch
                {
                    "google" => new GoogleAuth(),
                    "Facebook" => new FacebookAuth(),
                    _=>throw new Exception("Key has not found")
                };
            }
            return AuthList[name];
        }
        public int GetAuthCount()
        {
            return AuthList.Count;
        }

    }
}
