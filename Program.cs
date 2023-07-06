using System.ComponentModel;
using System.Reflection;

namespace cSharp_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Mohd", 3283, Gender.MALE, CarType.PERMIUM);
            User user2 = new User("Salma", 234553, Gender.FEMALE, CarType.BASIC);
            User user3 = new User("John", 47752, Gender.OTHER, CarType.VAN);

            //if (user1.gender = Gender.MALE)
            //{
            //    Console.WriteLine($"{user1.name} is {user1.gender}");
            
            //}
            //else
            //{
            //    Console.WriteLine($"{user1.name} is not male");
            //}
            Console.WriteLine((int)Gender.MALE);
            Console.WriteLine((int)CarType.BASIC);
            //string description = GetEnumDescription(CarType.PERMIUM);
            //Console.WriteLine(description);

            int orginalValue = 300;
            CarType type = (CarType)orginalValue;
            Console.WriteLine(type.ToString());

            // Task 1:Create an enum called DaysOfWeek to represent the days of the
            // week (Sunday, Monday, Tuesday, etc.). Write a program that prompts the
            // user to enter a day of the week and displays a message based on the entered value.
            // Use the switch statement to handle different cases.

            // Task 1:

            Console.WriteLine("\r\nTask 1: DaysOfWeek\r\n~~~~~~~~~~~~~~~");
            DayOfWeek.weekDays();

            // Task 2: Create an enum called ClothingSize to represent different clothing sizes (Small, Medium, Large, etc.).
            // Write a program that prompts the user to enter their clothing size and displays a message based on the entered value.
            // Use an if-else statement to handle different cases.
            Console.WriteLine("\r\nTask 2: ClothingSize\r\n~~~~~~~~~~~~~~~");
            Cloth.colthingSize();

            // Task 3: . Create an enum called FavoriteColor to represent different favorite colors (Red, Blue, Green, etc.).
            // Write a program that asks the user to enter their favorite color. If the entered color is one of the enum values,
            // display a message confirming their choice. If the entered color is not in the enum, display a message stating that
            // it is not a valid favorite color.
            Console.WriteLine("\r\nTask 3: FavoriteColor\r\n~~~~~~~~~~~~~~~");
            Color.favoriteColor();

            // Task 4: Write a program that converts an integer input to its corresponding enum value. Prompt the user to enter an integer and display the corresponding enum value.
            // Handle cases where the entered integer does not match any enum value by displaying an appropriate error message.
            Console.WriteLine("\r\nTask 4: EnumValue\r\n~~~~~~~~~~~~~~~");
            Enums.integerInput();
        }

        public static string GetEnumDescription(Enums value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes = fi.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            if (attributes != null && attributes.Any())
            {
                return attributes.First().Description;
            }

            return value.ToString();
        }
    }
}