using ChainOfresponsibility.Abstract;
using ChainOfresponsibility.Concrete;
using System;
using Model = ChainOfresponsibility.Model;
namespace ChainOfresponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Model::Document document = new Model.Document
            {
                Id = 1,
                Type = Model::DocumentType.Interview
            };
            Capacity Developer = new Developer("Tommy");
            Capacity Accountant = new Accountant("Joy");
            Developer.SetRelatedCapacity(Accountant).Handle(document);


        }
    }
}
