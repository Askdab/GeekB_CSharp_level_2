using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //Наследование интерфейсов, да, они так могут
    internal interface IExport : IExample
    {
        void Export();
        void Export(string path);
    }

    internal interface IExample
    {
        void Test();
    }

    //Два метода с одинаковыми именами из разных интерфейсов
    internal interface IExportLocally
    {
        void Export_new();
    }
    internal interface IExportToServer
    {
        void Export_new();
    }

    //При вызове интерфеса который наследуется от другого, необходимо вызывать все методы интерфейсов, даже от наследника
    internal class ExportWord : IExport, IExportLocally, IExportToServer
    {
        public void Export() { }

        public void Export(string path) { }

        public void Test() { }

        //Один из вариантов применения в классе двух методов с одинаковыми именами из разных интерфейсов
        void IExportLocally.Export_new()
        {
            throw new NotImplementedException();
        }
        void IExportToServer.Export_new()
        {
            throw new NotImplementedException();
        }

    }

    internal class ExportExcel : IExport, IExportLocally, IExportToServer
    {
        public void Export() { }

        public void Export(string path) { }

        public void Test() { }

        public void Export_new() { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //IEnumerator e = new Countdown();
            //Console.WriteLine($"Начало: {e.Current}");
            //while (e.MoveNext()) Console.WriteLine(e.Current);

            IExport export;
            if(true)
            {
                export = new ExportExcel();
            }
            else
            {
                export = new ExportWord();
            }

            //При двух методах с одинаковыми именами из разных интерфейсов необходимо при инициализации
            //указать необходимый интерфейс
            IExportLocally export_new1 = new ExportExcel();
            IExportToServer export_new2 = new ExportExcel();
            export_new1.Export_new();
            export_new2.Export_new();

            //Можно явно стипизировать применяемый интерфейс, для указания нужного метода,
            //при одинаковых именах разных интерфейсов
            ExportWord export_new = new ExportWord();
            ((IExportLocally)export).Export_new();
            ((IExportToServer)export).Export_new();
            Console.ReadKey();
        }
    }
}
