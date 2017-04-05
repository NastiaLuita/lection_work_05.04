using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Samost0504
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int n = 10;

            Console.WriteLine("*****SORT*****");

            var r = new Random();
            for (int i = 0; i < n; i++)
                list.Add(r.Next(0, 100));

            for (var i = 0; i < n; i++)
            {
                Console.Write(string.Join("; ", list[i]) + "; ");
            }

            DateTime start;
            DateTime end;

            start = DateTime.Now;
            list.Sort();
            end = DateTime.Now;
            Console.WriteLine(string.Format("\nElapsed: {0}", (end - start).TotalMilliseconds));

            for (var i = 0; i < n; i++)
            {
                Console.Write(string.Join("; ", list[i]) + "; ");
            }

            list.Clear();
            DateTime start1;
            DateTime end1;
            Console.WriteLine("\n*****BUBLE*****");
            
            for (int i = 0; i < n; i++)
                list.Add(r.Next(0, 100));

            for (var i = 0; i < n; i++)
            {
                Console.Write(string.Join("; ", list[i]) + "; ");
            }

            start1 = DateTime.Now;
            for (var i = 0; i < n - 1; i++)
            {
                for (var j = 0; j < n - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int c = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = c;
                    }
                }
            }
            end1 = DateTime.Now;
            Console.WriteLine(string.Format("\nElapsed: {0}", (end1 - start1).TotalMilliseconds));

            for (var i = 0; i < n; i++)
            {
                Console.Write(string.Join("; ", list[i]) + "; ");
            }

            Console.WriteLine("\n*****PERSON TEST*******");
            List<Person> listP = new List<Person> { new Person {Name = "Alex", Age = 21 },
                                                    new Person {Name = "TMaria", Age =  14 },
                                                    new Person {Name = "Ivan", Age = 18 },
                                                    new Person {Name = "Tanya", Age = 14 },
                                                    new Person {Name = "Dmytro", Age =  23 },
                                                    new Person {Name = "Sofia", Age =  10 }};
            Console.WriteLine("Before:");
            for (var i = 0; i < 6; i++)
            {
                Console.WriteLine(string.Join("; ", listP[i]) + "; ");
            }
            listP.Sort();
            Console.WriteLine("\nAfter:");
            for (var i = 0; i < 6; i++)
            {
                Console.WriteLine(string.Join("; ", listP[i]) + "; ");
            }

            Console.WriteLine("\n*****PEOPLE TEST*******");
            People data = new People();
            
            using(StreamReader sr = File.OpenText("people.txt"))
           
            data.LoadData(sr);
            Console.WriteLine("Before:\n" + data.ToString());
            data.Sort();
            Console.WriteLine("After:\n" + data.ToString());
        }
    }
}
