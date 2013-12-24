using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;

namespace Services
{
    public class CalculatorService:ICalculator
    {
        public double Add(double a, double b)
        {
            Console.WriteLine(a.ToString() +"+"+ b.ToString()+"=" +(a+b));
            return a + b;
        }
    }
}
