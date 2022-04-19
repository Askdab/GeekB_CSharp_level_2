using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers_hw_Lesson2
{
    class WorkerHorulyPayment : Workers
    {
        double MonthPayment;
        double Payment;

        public WorkerHorulyPayment(string name, double payment) : base(name, payment)
        {
            Payment = payment;
        }

        public override double AverageMonthlyPayment()
        {
            MonthPayment = 20.8 * 8 * Payment;
            return MonthPayment;
        }

    }
}
