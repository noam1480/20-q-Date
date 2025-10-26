using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Today);   //1

            DateTime date = new DateTime(2020, 11, 1, 8, 30, 0); //2
            Console.WriteLine(date);

            Console.WriteLine(date.AddDays(10)); //3

            if (DateTime.Today>date)
                Console.WriteLine("The day has been pasted ");      //4

            Console.WriteLine(DateTime.Parse("01/01/2020"));//6

            Console.WriteLine(date.Year);//7

            Console.WriteLine(date.DayOfWeek);//8

            Console.WriteLine(new DateTime(date.Year, 5, date.Day));//9

            Console.WriteLine(date.AddHours(10));//10

            Console.WriteLine(date.Day+"/"+date.Month+"/"+date.Year);//11

            TimeSpan t = new TimeSpan(2, 30, 0);    //  12
            Console.WriteLine(t);

            DateTime date4 = DateTime.Today.AddHours(11).AddMinutes(30); // 13
            Console.WriteLine(date4.ToString("HH:mm:ss")); 

            Console.WriteLine(DateTime.UtcNow); // 14 

            Console.WriteLine(date.Day.ToString()); //15

            if (date == DateTime.Now)
                Console.WriteLine("התאריכים שווים "); //16

            if (date.DayOfWeek == DayOfWeek.Friday || date.DayOfWeek == DayOfWeek.Saturday) //17
                Console.WriteLine("סופש");
            else
                Console.WriteLine("לא סופש");

            Console.WriteLine(date.ToString("MMMM d,yyyy")); //18

            Console.WriteLine((date-date4).Days); //19

            Console.WriteLine(DateTime.Now.ToShortDateString()); //20

        }
    }
}
