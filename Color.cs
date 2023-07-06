using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Enum
{
    internal class Color
    {
        public static void favoriteColor() 
        {
            Console.WriteLine("What is your favirite color? ");
            string faviriteColor = Console.ReadLine();

            FavoriteColor vColor = (FavoriteColor)Enum.Parse(typeof(FavoriteColor), faviriteColor);

            switch (vColor)
            {
                case FavoriteColor.Red:
                    Console.WriteLine("Your Favorite color is RED");
                    break;
                case FavoriteColor.Blue:
                    Console.WriteLine("Your Favorite color is BLUE");
                    break;
                case FavoriteColor.Green:
                    Console.WriteLine("Your Favorite color is GREEN");
                    break;
                case FavoriteColor.Yellow:
                    Console.WriteLine("Your Favorite color is YELLOW");
                    break;
                case FavoriteColor.Orange:
                    Console.WriteLine("Your Favorite color is Orange");
                    break;
                case FavoriteColor.Purple:
                    Console.WriteLine("Your Favorite color is Purple");
                    break;
                default: 
                    Console.WriteLine("Invalid color ....");
                    break;

            }
        
        }
    }


    enum FavoriteColor
    {
        Red,
        Blue,
        Green,
        Yellow,
        Orange,
        Purple
    }

}
