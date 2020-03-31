using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgLab_3_3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] array = getArray(10);


            //var proccesedArr = from t in array
            //                   select t * array.IndexOf(t);
            int counter = 0;
            IEnumerable<int> proccesedArr = array.Select(i => { int a = i * counter; counter++; return a; }).ToArray();

            IEnumerable<int> proccesedArr1 = from t in proccesedArr
                                             where t.ToString().Length == 2
                                             select t;






            Console.WriteLine("Початковий масив");
            foreach (var a in array)
            {
                Console.Write(a);
                Console.Write("\t");
            }
            Console.WriteLine("\nОтримати послідовність чисел, кожен елемент якого дорівнює добутку відповідного елемента вихідної послідовності на його порядковий номер(1, 2, ...)");   
            Console.WriteLine();
            Console.WriteLine();
            foreach (var a in proccesedArr)
            {
                Console.Write(a);
                Console.Write("\t");
            }
            Console.WriteLine("\nВ отриманій послідовності видалити всі елементи, які не є двозначними, і поміняти порядок елементів, що залишилися, на зворотний");
            Console.WriteLine();
            Console.WriteLine();
            foreach (var a in proccesedArr1.OrderByDescending(t => t))
            {
                Console.Write(a);
                Console.Write("\t");
            }
            
            Console.ReadLine();
            




        }
        public static int[] getArray(uint size)
        {
            var arr = new int[size];
            var rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1,10);
            }
            return arr;
        }
        

    }
    static class ArrayExtension
    {
        public static int FindIndex<T>(this IEnumerable<T> items, Func<T, bool> predicate)
        {
            if (items == null) throw new ArgumentNullException("items");
            if (predicate == null) throw new ArgumentNullException("predicate");

            int retVal = 0;
            foreach (var item in items)
            {
                if (predicate(item)) return retVal;
                retVal++;
            }
            return -1;
        }

        public static int IndexOf<T>(this IEnumerable<T> items, T item) { return items.FindIndex(i => EqualityComparer<T>.Default.Equals(item, i)); }

    }
    //public static class ArrayExtension
    //{
    //    public static int IndexOf(this int[] arr, int elem)
    //    {
    //        int counter = 0;
    //        foreach (int i in arr)
    //        {
    //            counter++;
    //            if (i == elem)
    //            {
    //                return counter;
    //            }

    //        }
    //        return -1;
    //    }
    //}
   
}
