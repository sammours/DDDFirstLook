using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DDDFirstLook.WebMvc
{
    public static class DrinkMaker
    {
        private static readonly string[] drinks = new[] { "Juice", "Cola", "Beer" };

        public static void MakeDrink(string value, int age)
        {
            if (!IsAvailableDrink(value))
            {
                Console.WriteLine("Sorry mate, we don't have this drink");
            }

            CheckMenu(value, age);
        }

        private static bool IsAvailableDrink(string value)
        {
            return drinks.Contains(value);
        }

        private static void CheckMenu(string value, int age)
        {
            if (value == "Juice")
            {
                Console.WriteLine("Here you go: Juice");
                return;
            }

            if (value == "Beer")
            {
                CkeckAge(age);
                return;
            }

            Console.WriteLine("Here you go: Cola");
            return;
        }

        private static void CkeckAge(int age)
        {
            if (age > 18)
            {
                Console.WriteLine("You are grown up");
            }
            else
            {
                Console.WriteLine("Sorry, you are too young");
            }
        }
    }
}
