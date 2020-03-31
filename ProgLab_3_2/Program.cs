
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace ProgLab_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = CreateDict();
            
            Console.WriteLine("Before sort :");
            ShowDict(dict);

            foreach (var listKey in dict.Keys)
            {
                listKey.Sort();

            }
            Console.WriteLine("After sort :");
            ShowDict(dict);

            var dictStr = ListsToStrings(dict);
            var json = JsonConvert.SerializeObject(dict);
            File.WriteAllText(@"resulltatik.json", JsonConvert.SerializeObject(dictStr));





            Console.ReadKey();
        }
        public static  Dictionary<List<string>, string> CreateDict()
        {
            var dict = new Dictionary<List<string>, string>();
            dict[new List<string> { "aa", "nn", "bb" }] = "One";
            dict[new List<string> { "cvcv", "whsn", "JTKTK" }] = "Two";
            dict[new List<string> { "eeyundn", "yoythwgwv", "nmkfndsvfgs" }] = "Three";
            dict[new List<string> { "zvbdn", "rvib", "frni" }] = "Four";
            return dict;
        }
        public static  void ShowDict(Dictionary<List<string>, string> dict)
        {
            Console.WriteLine("{");
            foreach (var listKey in dict.Keys)
            {
                Console.Write("[");
                foreach (var i in listKey)
                {
                    Console.Write(i );
                    if (i != listKey.Last())
                    {
                        Console.Write(" , ");
                    }
                }
                Console.Write("] : ");
                Console.WriteLine(dict[listKey]);


            }
            Console.WriteLine("}");
        }
        public static Dictionary<string, string> ListsToStrings(Dictionary<List<string>, string> dict)
        {
            var res = new Dictionary<string, string>();
            foreach (var listKey in dict.Keys)
            {
                string newKey = "[ ";
                foreach (var i in listKey)
                {
                    newKey += i;
                    if (i != listKey.Last())
                    {
                        newKey += " , ";
                    }
                }
                newKey += " ]";
                res[newKey] = dict[listKey];

            }
            return res;
        }
       

    }
   
    }



