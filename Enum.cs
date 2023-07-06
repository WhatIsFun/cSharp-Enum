using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace cSharp_Enum
{
    internal class Enums
    {
        public static void integerInput()
        {
            Console.WriteLine($"Enum:\r\n Dog = {(int)EnumValue.Dog}\r\n Cat = {(int)EnumValue.Cat}\r\n Goat = {(int)EnumValue.Goat}" +
                $"\r\n camle = {(int)EnumValue.Camel}\r\n Bird = {(int)EnumValue.Bird}");

            Console.WriteLine("Enter a value: ");
            int value = Convert.ToInt32(Console.ReadLine());
            EnumValue v = (EnumValue)value;

            if (v == EnumValue.Dog)
            {
                Console.WriteLine("This value for Dog");
            }
            else if (v == EnumValue.Cat)
            {
                Console.WriteLine("This value for Cat");
            }
            else if (v == EnumValue.Camel)
            {
                Console.WriteLine("This value for Camel");
            }
            else if (v == EnumValue.Goat)
            {
                Console.WriteLine("This value for Goat");
            }
            else if (v== EnumValue.Bird)
            {
                Console.WriteLine("This value for Bird");
            }
            else 
            {
                Console.WriteLine("Error !!!!");
            }

        }

    }
    enum EnumValue
    {
        Dog = 100,
        Cat = 150,
        Goat = 300,
        Camel = 1000,
        Bird = 50
    }
}
