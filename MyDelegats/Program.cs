using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDelegats
{
    //delegate bool IsChar(char c);
    public delegate int D(int a, int b);
    

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

        delegate void Message();

        static void Hello() => Console.WriteLine("Привет");

        static int Sum(int x, int y) => x + y;

        static int Multy(int x, int y) => x * y;

        static void Main(string[] args)
        {
            D kek = Sum;

            Console.WriteLine(kek.Invoke(10, 15));

            int a = kek(10, 15);
            Console.WriteLine(a);

            kek = Multy;
            a = kek(10, 15);
            Console.WriteLine(a);

            Console.ReadKey();
        }
    }
}
