using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers_hw_Lesson2
{
    class WorkerFixedPayment : Workers
    {
        double MonthPayment;
        double Payment;

        public WorkerFixedPayment(string name, double payment) : base(name, payment)
        {
            Payment = payment;
        }

        public override double AverageMonthlyPayment()
        {
            MonthPayment = Payment;
            return MonthPayment;
        }
    }
}
