using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Services;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Hosting
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(CalculatorService)))
            {
                host.Opened += delegate
                {
                    Console.WriteLine("服务已启动,q退出");
                };
                host.Open();
                
                string str = string.Empty;
                
                str=Console.ReadLine();
                while (str != "q")
                {
                    str = Console.ReadLine();
                }
            }
        }
    }
}
