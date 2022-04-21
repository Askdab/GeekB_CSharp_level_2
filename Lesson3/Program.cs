using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    enum Sex
    {
        Male,
        Female,
        Undifined
    }

    //Если добавить where U : class - то можно будет использовать вместо U
    //Только  ссылочные типы данных, аналогично struct для значимых (where U : struct)
    class Animal<T, U> where U : class
    {
        public T Gender = default(T);
        public U Id = default(U);
    }

    class Program
    {
        //Обобщенный метод, в данном случае за T выступает некий тип, который будет проинициализирован в программе
        //Применяется, когда нам не известно какой тип данных понадобится использовать
        //Обобщение - Generetics
        static void Swap<T>(ref T a, ref T b)
        {
            T c = default(T);
            c = a;
            a = b;
            b = c;
        }

        static void Main(string[] args)
        {
            //При добавлении второго типа как string (он у нас ссылочный) все ок
            Animal<Sex, string> animal = new Animal<Sex, string>() { Gender = Sex.Male, Id = "1" };
            //animal.Gender = "Male";
            //animal.Gender = Sex.Male;

            //Но при добавлении второго типа как bool, среда ругается, bool - значимый тип
            Animal<string, bool> animal1 = new Animal<string, bool> { Gender = "Male", Id = false };

            Console.WriteLine(animal.Gender + " " + animal.Id);
            Console.WriteLine(animal1.Gender + " " + animal1.Id);

            Console.ReadKey();
        }
    }
}
