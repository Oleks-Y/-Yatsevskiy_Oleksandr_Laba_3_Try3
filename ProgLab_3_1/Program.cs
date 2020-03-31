

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgLab_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>();

            Console.WriteLine("Введіть числа (Enter для закінчення вводу)");
            while (true)
            {
                var a = Console.ReadLine();
                if (a == "") break;
                list.Add(a);
                
            }
            Console.WriteLine("Result : ");
            for(int i = 0; i < list.Count; i += 2)
            {
                if (i >= list.Count - 1)
                {

                }
                else
                {
                    
                    string a = list[i];
                    list[i] = list[i+1];
                    list[i+1] = a;
                }
            }
            foreach(string s in list)
            {
                Console.Write(s + " , ");
            }
            Console.ReadKey();


        }
    }
}
