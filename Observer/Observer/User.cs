using Observer.Subject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Observer
{
    class User : IOberserver
    {
        private string Name;
        public User(string name) => Name = name;
        public void Perform(ISubject subject)
        {
            Console.WriteLine($"{Name} {subject.Desc}");
        }
        public void Perform(object e, ISubject subject)
        {
            Console.WriteLine($"{Name} {subject.Desc}");
        }
    }
}
