using Strategy.Concrete;
using System;

namespace Strategy
{


    class Program
    {
        static void Main(string[] args)
        {
            Performance performance = new Performance();
            performance.SetPerformance(new PerformViolin());
            performance.Perform();
            performance.SetPerformance(new PerformSing());
            performance.Perform();
            performance.SetPerformance(new PerformDance());
            performance.Perform();




        }
    }
}
