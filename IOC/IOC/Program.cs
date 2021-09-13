using IOC.Container;
using System;

namespace IOC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var container = new IOCContainer();

            container.Register<ICalculator, Calculator>(ServiceLifetime.Transient);
            container.Register<ICalculator, Calculator>(ServiceLifetime.Singleton);
            
            var serviceFirst = container.Resolve<ICalculator>();
            var serviceSecond = container.Resolve<ICalculator>();
            
            serviceFirst.Sum();
            serviceSecond.Sum();

        }
    }
}
