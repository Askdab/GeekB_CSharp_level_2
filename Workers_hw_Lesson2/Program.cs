using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers_hw_Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkerFixedPayment Alex = new WorkerFixedPayment("Alex", 35000);
            Console.WriteLine("Алекс у нас имеет фиксированную зарплату: " + Alex.AverageMonthlyPayment());

            WorkerHorulyPayment Victor = new WorkerHorulyPayment("Victor", 150);
            Console.WriteLine("А Витя у нас с почасовой оплатой: " + Victor.AverageMonthlyPayment());
            Console.ReadKey();
        }
    }
}
