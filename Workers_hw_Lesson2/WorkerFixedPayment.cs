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
        public WorkerFixedPayment(string name, double payment) : base(name, payment)
        {
        }

        public override double AverageMonthlyPayment()
        {
        }
    }
}
