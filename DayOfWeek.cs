using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Enum
{
    internal class DayOfWeek
    {
        public static void weekDays()
        { 
        Console.WriteLine("Enter a day of the week: ");
        string weekday = Console.ReadLine();
        DaysOfWeek day = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), weekday); //This is to convert from enum type to string

            switch (day)
            {
                case DaysOfWeek.Sunday:
                    Console.WriteLine("It is Sunday Funday");
                    break;
                case DaysOfWeek.Monday:
                    Console.WriteLine("It is Monday ");
                    break;
                case DaysOfWeek.Tuesday:
                    Console.WriteLine("It is Tuesday");
                    break;
                case DaysOfWeek.Wednesday:
                    Console.WriteLine("It is Wednesday");
                    break;
                case DaysOfWeek.Thursday:
                    Console.WriteLine("It is Thursday");
                    break;
                case DaysOfWeek.Friday:
                    Console.WriteLine("It is Friday");
                    break;
                case DaysOfWeek.Saturday:
                    Console.WriteLine("It is Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid Day, Please try again!!!! ");
                    break;
            }
        }
    }

    enum DaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
    }
}
