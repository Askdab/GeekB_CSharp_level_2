using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace ReadFromTxt
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllText("data.txt");
            var arrayData = text.Split(',');
            var sum = 0;

            foreach(var e in arrayData)
            {
                int r = Int32.Parse(e);
                if (r % 2 == 0) sum += r;
            }

            WriteLine(sum);

            ReadKey();
        }
    }
}
