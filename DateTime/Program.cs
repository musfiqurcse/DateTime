using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeApps
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime myValue = DateTime.Now;
            //Console.WriteLine(myValue.ToString());
            //Console.WriteLine(myValue.ToShortDateString());
            //Console.WriteLine(myValue.ToShortTimeString());
            //Console.WriteLine(myValue.ToLongDateString());
            //Console.WriteLine(myValue.ToLongTimeString());
            //Console.WriteLine(myValue.AddDays(2).ToShortDateString());
            //Console.WriteLine(myValue.AddDays(-3).ToShortDateString());
            //Console.WriteLine(myValue.AddHours(3).ToShortTimeString());
            //Console.WriteLine(myValue.Month.ToString());

            //DateTime myBirthday= new DateTime(570,5,5);
            //Console.WriteLine(myBirthday.ToLongDateString());
            DateTime myBirthday = DateTime.Parse("4/8/1992");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalDays
                );

            Console.ReadLine();

        }
    }
}
