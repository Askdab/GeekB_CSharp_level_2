using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDelegats
{
    //delegate bool IsChar(char c);
    //public delegate int D(int a, int b);

    #region Обобщенные делегаты - Action, Func и Predicate
    //А как насчет ОБОБЩЕННЫХ ДЕЛЕГАТОВ БИЧ
    //public delegate void GenereticDelegate<T> (T t);
    //public delegate T1 GenereticDelegateT<T1> (T1 t1);

    //Которые, кстати не нужны, потому что в библиотеке уже заложен
    //обобщенный делегат Action, принимающий различные параментры и возвращающий void
    //Action<int, string> da2;

    //Также, есть обобщенный делегат Func, который возвращает значение
    //Func<Входной параметр, входной параметр ..., выходной параметр (возвращаемый тип)>

    //Есть еще ПРЕДИКАТ Predicate - обобщенный делегат, который возвращает всегда bool
    //Predicate<T> b - можно его также прописать как Func<T, bool>
    #endregion

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
