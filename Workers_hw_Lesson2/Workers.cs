using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers_hw_Lesson2
{
    abstract class Workers
    {
        string Name;
        double Payment;
        public static Workers[] Mass = new Workers[] { new WorkerFixedPayment("Slava", 45000), new WorkerHorulyPayment("Sanya", 180), new WorkerFixedPayment("Katya", 100000),
            new WorkerFixedPayment("Askhab", 180000), new WorkerHorulyPayment("Vlad", 210) };

        public Workers(string name, double payment)
        {
            this.Name = name;
            this.Payment = payment;
        }

        public abstract double AverageMonthlyPayment();
    }
}
