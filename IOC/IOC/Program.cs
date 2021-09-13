using IOC.Container;
using System;

namespace IOC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("\nStart...");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Creating the Container");
            var container = new IOCContainer();

            ////Register as Transient
            //Console.WriteLine("Registering as Transient");
            //container.Register<ICalculator, Calculator>(LifeCycleFlag.Transient);

            //Register as Singleton
            Console.WriteLine("Registering as Singleton");
            container.Register<ICalculator, Calculator>(LifeCycleFlag.Singleton);

            //Resolve the Service 
            Console.WriteLine("Resolving the Service");
            var serviceFirst = container.Resolve<ICalculator>();

            //Resolve the Service 
            Console.WriteLine("Resolving the Service");
            var serviceSecond = container.Resolve<ICalculator>();


            Console.WriteLine("\nResult from Service One");
            serviceFirst.Sum();

            Console.WriteLine("\nResult from Service One");
            serviceSecond.Sum();

        }
    }
}
