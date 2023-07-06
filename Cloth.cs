using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Enum
{
    internal class Cloth
    {
        public static void colthingSize()
        {

            Console.WriteLine("Enter your cloth size number in EU >> ");
            //string size = Console.ReadLine();
            int orginalSize = Convert.ToInt32(Console.ReadLine());
            ClothingSize vSize = (ClothingSize)orginalSize;


            if (vSize == ClothingSize.Small)
            {
                Console.WriteLine("Your size is 36 in UE which is Small");
            }
            else if (vSize == ClothingSize.Medium)
            {
                Console.WriteLine("Your size is 38 in UE which is Medium");
            }
            else if (vSize == ClothingSize.Large)
            {
                Console.WriteLine("Your size is 40 in UE which is Large");
            }
            else if (vSize == ClothingSize.XLarge)
            {
                Console.WriteLine("Your size is 42 in UE which is XLarge");
            }
            else if (vSize == ClothingSize.XXLarge)
            {
                Console.WriteLine("Your size is 44 in UE which is XXLarge") ;
            }
            else { Console.WriteLine("Invalid input ~`~"); }
    }
    }

    enum ClothingSize
    {
        Small= 36,
        Medium = 38,
        Large = 40,
        XLarge = 42,
        XXLarge = 44
    }
}
