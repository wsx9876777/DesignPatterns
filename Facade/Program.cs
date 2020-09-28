using Facade.Concrete;
using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new People()
            {
                Name = "Tommy",
                AnnualIncome = 100000,
                HouseProperty = 0,
                Saving = 1000000
            };
            var subsidy = new GovermentSubsidy();
            var IsEligible = subsidy.isEligible(people);
            var str = IsEligible ? "passed" : "No Passed";
            Console.WriteLine($"Hi {people.Name}~ Your application of subsidy was {str}");
        }
    }
}
