using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekB_CSharp_level_2
{
    class A 
    { 
        static Random rand = new Random();

        public A()
        {
            Console.WriteLine(rand.Next(100));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 30; i++)
            {
                new A();
            }
            Console.ReadKey();
        }
    }
}
