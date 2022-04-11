using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson1HW_Asteroids
{
    class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();
            form.Width = 800;
            form.Height = 600;
            form.Show();
            Application.Run(form);
        }
    }
}
