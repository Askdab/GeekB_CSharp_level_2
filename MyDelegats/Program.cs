using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDelegats
{
    //delegate bool IsChar(char c);

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


        static void Main(string[] args)
        {

            Console.ReadKey();
        }
    }
}
