using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer numero");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            int b = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("{0} + {1} = {2}",a,b,a+b);

            Console.ReadLine();

        }
    }
}
