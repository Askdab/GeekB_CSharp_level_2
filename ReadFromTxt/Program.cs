using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace ReadFromTxt
{
    class Program
    {
        //Методы для второго способа, которые кста не нужны, потому что
        //мы их вписали анонимным методом

        //static bool Search(int Item) { return Item % 2 == 0; }
        //static int ConvertStringToInt(string Str) { return Convert.ToInt32(Str); }

        static void Main(string[] args)
        {
            #region Первый способ чтения с файла и сложения четных чисел
            //var text = File.ReadAllText("data.txt");
            //var arrayData = text.Split(' ');
            //var sum = 0;

            //foreach(var e in arrayData)
            //{
            //    int r = Int32.Parse(e);
            //    if (r % 2 == 0) sum += r;
            //}

            //WriteLine(sum);
            #endregion

            #region Второй способ, путем использования слова делегат
            //var sum = File.ReadAllText("data.txt")
            //                        .Split(' ')
            //                        .Select(delegate(string Str) { return Convert.ToInt32(Str); })
            //                        .Where(delegate(int Item) { return Item % 2 == 0; })
            //                        .ToArray()
            //                        .Sum();
            #endregion

            //Мы кстати слышали, что где используется слово делегает в анонимных
            //методах, можно просто заменить лямбда выражением => и имена переменных сократить
            //до одного символа

            #region Третий способ путем использования ЛЯМБДА выражений
            var sum = File.ReadAllText("data.txt")
                                    .Split(' ')
                                    .Select(s => Convert.ToInt32(s))
                                    .Where(i => i % 2 == 0)
                                    .ToArray()
                                    .Sum();
            #endregion
            Console.WriteLine(sum);
            ReadKey();
        }
    }
}
