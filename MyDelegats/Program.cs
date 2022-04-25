using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDelegats
{
    //delegate bool IsChar(char c);
    //public delegate int D(int a, int b);
    public delegate double Fun(double x);


    class Program
    {
        #region Сколько латинских и сколько русских букв в слове
        //static bool IsLatin(char c)
        //{
        //    c = char.ToUpper(c);
        //    return c >= 'A' && c <= 'Z';
        //}

        //static bool IsRus(char c)
        //{
        //    c = char.ToUpper(c);
        //    return c >= 'А' && c <= 'Я';
        //}

        //static int CountChar(string s, IsChar isChar)
        //{
        //    int count = 0;
        //    foreach (char c in s)
        //    {
        //        if (isChar(c)) count++;
        //    }
        //    return count;
        //}
        #endregion

        #region Методы сложения и умножения
        //static int Sum(int x, int y) => x + y;

        //static int Multy(int x, int y) => x * y;
        #endregion

        public static void Table(Fun f, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x < b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, f?.Invoke(x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }

        public static double Simple(double x) => x * x;

        static void Main(string[] args)
        {
            #region Балуемся с сложением и умножением при помощи делегата
            //D kek = Sum;

            //Console.WriteLine(kek.Invoke(10, 15));

            //int a = kek(10, 15);
            //Console.WriteLine(a);

            //kek = Multy;
            //a = kek(10, 15);

            //Console.WriteLine(a);
            #endregion

            Console.WriteLine("Таблица функции Sin:");
            Table(Math.Sqrt, -2, 2);
            Console.WriteLine("Таблица функции Simple:");
            Table(Simple, 0, 3);

            Console.ReadKey();
        }
    }
}
