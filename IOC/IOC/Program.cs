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

            container.Register<ICalculator, Calculator>(LifeCycleFlag.Transient);
            //container.Register<ICalculator, Calculator>(LifeCycleFlag.Singleton);

            var serviceFirst = container.Resolve<ICalculator>();
            var serviceSecond = container.Resolve<ICalculator>();

            serviceFirst.Sum();
            serviceSecond.Sum();

        }
    }
}
