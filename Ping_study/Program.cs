using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ping_study
{
    class Program
    {
        static void Main(string[] args)
        {
            string address = "192.0.0.1";
            Console.WriteLine(Convert.ToString(LanStatusCheck.IsEffectiveness(address)));
            Console.ReadKey();
        }
    }
}
