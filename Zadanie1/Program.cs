using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Program
    {
        struct Time
        {
            public int hours;
            public int minutes;
            public int second;


            public int CompareTo(Time b)
            {
                if(this.hours == b.hours)
                {
                    return 0;
                }
                else
                {
                    if (this.hours > b.hours)
                        return 1;
                    else return -1;
                }
            }
        }



        static void Main(string[] args)
        {
            Time a = new Time();
            Time b = new Time();
            Time c = new Time();
            a.hours = 10;
            b.hours = 10;
            c.hours = 12;
            Console.WriteLine(a.CompareTo(b) + "  a & b");
            Console.WriteLine(a.CompareTo(c) + "  a & c");
            Console.ReadKey();
        }
    }
}
