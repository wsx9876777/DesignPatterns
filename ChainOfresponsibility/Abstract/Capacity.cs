using System;
using System.Collections.Generic;
using model = ChainOfresponsibility.Model;
using System.Text;

namespace ChainOfresponsibility.Abstract
{
    abstract class Capacity
    {
        private Capacity _capacity;
        private string _Name;
        public abstract model::DocumentType documentType { get;}
        public string Name => _Name;
        public Capacity RelatedCapacity => _capacity;
        public Capacity(string name)
        {
            _Name = name;
        }
        public Capacity SetRelatedCapacity(Capacity capacity)
        {
            _capacity = capacity;
            return this;
        }

        public virtual void Handle(model::Document document) {
            if (document.Type == documentType)
            {
                Console.WriteLine($"{Name} handling this document");
            }
            else
            {
                Console.WriteLine($"{Name} can't handle this document,Forward to Related people");
                if (RelatedCapacity != null)
                {
                    RelatedCapacity.Handle(document);
                }
                else
                {
                    Console.WriteLine($"Sorry no Related People can handle this document");
                }
            }
        }
    }
}
