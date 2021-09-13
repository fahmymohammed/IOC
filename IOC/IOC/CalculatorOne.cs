using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC
{
    
    public class CalculatorOne : ICalculatorOne
    {
        int numberOne = new Random().Next(0, 10);
        int numberTwo = new Random().Next(0, 10); 
        public void Sum() => Console.WriteLine( numberOne+ numberTwo);
    }
}
