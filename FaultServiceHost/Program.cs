using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace FaultServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(FaultServiceApp.Service1));
            host.Open();
            Console.WriteLine("Host started ...............");
            Console.ReadLine();
        }
    }
}
