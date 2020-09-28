using Observer.Observer;
using Observer.Subject;
using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = new SubjectNewProdect();
            subject.Attach(new User("Ice").Perform);
            subject.Attach(new User("Joy").Perform);
            subject.Notify("妳好嗎");
        }
    }
}
