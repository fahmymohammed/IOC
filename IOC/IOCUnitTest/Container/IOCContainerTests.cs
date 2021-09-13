using Microsoft.VisualStudio.TestTools.UnitTesting;
using IOC.Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.Container.Tests
{
    [TestClass()]
    public class IOCContainerTests
    {
        //Test Constructor
        [TestMethod()]
        public void IOCContainerTest()
        {
            var container = new IOCContainer();
            int count = container.GetRegisteredCount();
            Assert.AreEqual(count, 0);
        }
        //Test Register as Singleton
        [TestMethod()]
        public void Register_Singleton_Test()
        {
            var container = new IOCContainer();
            int count = container.GetRegisteredCount();
            container.Register<ICalculatorOne, CalculatorOne>(LifeCycleFlag.Singleton);

            int abc = container.GetRegisteredCount();
            Assert.IsTrue(abc > count);
        }
        //Test the Default as Register Transient
        [TestMethod()]
        public void Register_Default_Transient_Test()
        {
            var container = new IOCContainer();
            int count = container.GetRegisteredCount();
            container.Register<ICalculatorOne, CalculatorOne>();

            int abc = container.GetRegisteredCount();
            Assert.IsTrue(abc > count);
        }

        //Test Resolve to Retreve the correct Object 
        [TestMethod()]
        public void ResolveTest()
        {
            var container = new IOCContainer();
            container.Register<ICalculatorOne, CalculatorOne>();

            var serviceSingletonOne = container.Resolve<ICalculatorOne>();

            //Object != Null
            Assert.IsNotNull(serviceSingletonOne);

            //Object must be as same type as Registered
            Assert.IsTrue(serviceSingletonOne is ICalculatorOne);

        }

        //Test Resolve Singleton
        [TestMethod()]
        public void Test_Resolve_Singleton()
        {
            var container = new IOCContainer();
            container.Register<ICalculatorOne, CalculatorOne>(LifeCycleFlag.Singleton);
            var serviceSingletonOne = container.Resolve<ICalculatorOne>();
            var serviceSingletonTwo = container.Resolve<ICalculatorOne>();

            //to same Onject
            Assert.IsTrue(serviceSingletonOne == serviceSingletonTwo);

        }

        //Test Resolve Transient
        [TestMethod()]
        public void Test_Resolve_Transient()
        {
            var container = new IOCContainer();

            container.Register<ICalculatorTwo, CalculatorTwo>(LifeCycleFlag.Transient);
            var serviceTransientOne = container.Resolve<ICalculatorTwo>();
            var serviceTransientTwo = container.Resolve<ICalculatorTwo>();

            //!same Onject
            Assert.IsFalse(serviceTransientOne == serviceTransientTwo);

        }
    }
}