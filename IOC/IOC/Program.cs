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
            
            Console.WriteLine("\tCreating the Container");
            Console.WriteLine("\t---------------------");
            var container = new IOCContainer();

            //Register as Singleton
            Console.WriteLine("Registering as Singleton");
            container.Register<ICalculatorOne, CalculatorOne>(LifeCycleFlag.Singleton);

            //Resolve the Service 
            Console.WriteLine("Resolving the Service a Singleton First Time");
            var serviceSingletonOne = container.Resolve<ICalculatorOne>();
            Console.WriteLine("Resolving the Service a Singleton Second Time");
            var serviceSingletonTwo = container.Resolve<ICalculatorOne>();


            Console.WriteLine("\nResult from Singleton Service One");
            serviceSingletonOne.Sum();

            Console.WriteLine("\nResult from Singleton Service Two");
            serviceSingletonTwo.Sum();

            Console.WriteLine("\n--------------------------------");

            //Register as Transient
            Console.WriteLine("Registering as Transient");
            container.Register<ICalculatorTwo, CalculatorTwo>(LifeCycleFlag.Transient);

            //Resolve the Service 
            Console.WriteLine("Resolving the Service as Transient First Time");
            var serviceTransientOne = container.Resolve<ICalculatorTwo>();

            //Resolve the Service 
            Console.WriteLine("Resolving the Service as Transient Second Time");
            var serviceTransientTwo = container.Resolve<ICalculatorTwo>();


            Console.WriteLine("\nResult from Service Transient One");
            serviceTransientOne.Sum();

            Console.WriteLine("\nResult from Service Transient Two");
            serviceTransientTwo.Sum();


        }
    }
}
