using System;

namespace Assignment01OOP
{
    class Program
    {
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }

        [Flags]
        enum Permissions
        {
            None = 0,
            Read = 1,
            Write = 2,
            Delete = 4,
            Execute = 8
        }

        enum Colors
        {
            Red,
            Green,
            Blue
        }

        static void Main(string[] args)
        {
            #region Q1. Create an Enum called "WeekDays" with the days of the week and print all days.
            Console.WriteLine("Days of the week:");
            foreach (var day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }
            #endregion

            #region Q2. Create an Enum called "Season" and display the month range for a given season.
            Console.Write("Enter a season name (Spring, Summer, Autumn, Winter): ");
            string seasonInput = Console.ReadLine();

            if (Enum.TryParse(seasonInput, true, out Season selectedSeason))
            {
                switch (selectedSeason)
                {
                    case Season.Spring:
                        Console.WriteLine("Spring: March to May");
                        break;
                    case Season.Summer:
                        Console.WriteLine("Summer: June to August");
                        break;
                    case Season.Autumn:
                        Console.WriteLine("Autumn: September to November");
                        break;
                    case Season.Winter:
                        Console.WriteLine("Winter: December to February");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid season entered.");
            }
            #endregion

            #region Q3. Assign Permissions using an Enum and manage them.
            Permissions userPermissions = Permissions.Read | Permissions.Write;

            Console.WriteLine("Initial Permissions: " + userPermissions);

            Console.WriteLine("Adding Execute Permission.");
            userPermissions |= Permissions.Execute;
            Console.WriteLine("Updated Permissions: " + userPermissions);

            Console.WriteLine("Removing Write Permission.");
            userPermissions &= ~Permissions.Write;
            Console.WriteLine("Updated Permissions: " + userPermissions);

            Console.WriteLine("Checking if Read Permission exists.");
            bool hasRead = (userPermissions & Permissions.Read) == Permissions.Read;
            Console.WriteLine("Read Permission exists: " + hasRead);
            #endregion

            #region Q4. Create an Enum called "Colors" and check if a color is primary.
            Console.Write("Enter a color name: ");
            string colorInput = Console.ReadLine();

            if (Enum.TryParse(colorInput, true, out Colors selectedColor))
            {
                Console.WriteLine($"{selectedColor} is a primary color.");
            }
            else
            {
                Console.WriteLine($"{colorInput} is not a primary color.");
            }
            #endregion
        }
    }
}
