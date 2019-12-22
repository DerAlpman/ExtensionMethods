using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethods
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            if (args == null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            //Console.WriteLine("Extension Methoden können die Lesbarkeit des Codes verbessern.");
            //Console.WriteLine("Sie können Code kapseln und wiederverwendbar machen.");
            //Console.WriteLine();

            //string value = "alles klein";

            //value = value.UppercaseFirstLetter();
            //Console.WriteLine(value);

            //value = StringExtensions.LowercaseFirstLetter(value);
            //Console.WriteLine(value);

            //string nullValue = null;

            //try
            //{
            //    int i = nullValue.Length;
            //}
            //catch (NullReferenceException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //try
            //{
            //    nullValue.Null();
            //}
            //catch (NullReferenceException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //Console.WriteLine();

            //Console.WriteLine("Man hat in Extension Methods nur Zugriff auf die öffentlichen Methoden, Properties und Felder!");
            //Console.WriteLine("Extension Methods können dazu führen, dass zuviele ungewünschte Abhängigkeiten zwischen Assemblies entstehen!");
            //Console.WriteLine();

            //Console.WriteLine(nullValue.IsNull());
            //Console.WriteLine();

            //Console.WriteLine("Fazit: Extension Methoden nur schreiben, wenn es wirklich nötig ist.");

            IList<int> list = new List<int>();
            list.Add(3);
            list.Add(4);
            list.Add(5);

            //foreach (var item in list.Where(x => x > 4))
            //{
            //        Console.WriteLine(item);
            //}

            list.Where(x => x > 4).ToList().ForEach(x => Console.WriteLine(x));

            Console.ReadKey();
        }
    }
}
