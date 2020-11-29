using System;

namespace Design_Patterns___Faceted_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new CarBuilderFacade()
                .Info
                .WithType("BMW")
                .WithColor("Black")
                .WithNumberOfDoors(5)
                .Built
                .InCity("Leipzig")
                .AtAddress("Some addres 253")
                .Build();

            Console.WriteLine(car);
        }
    }
}
