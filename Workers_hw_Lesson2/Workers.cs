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

        public Workers(string name, double Payment)
        {
            this.Name = name;
            this.Payment = Payment;
        }

        public abstract double AverageMonthlyPayment();
    }
}
