using CleanNails.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanNails
{
    internal class Printer
    {
        public static void MenuChoice(string saloonName)
        {
            Console.Clear();
            Console.WriteLine($"Welcome to {saloonName}");
            Console.WriteLine();
            Console.WriteLine("1. Create customer");
            Console.WriteLine("2. Delete customer");
            Console.WriteLine("3. List all customers");
            Console.WriteLine("4. Change preferred length of nails");
            Console.WriteLine("5. Simulate days");
            Console.WriteLine("6. Quit");

            Console.Write("\nEnter choice: ");
        }

        public static void PrintClippedFingerNail(Person person, string staffName, Nail nail)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(staffName);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($" just clipped {person.Name}'s ");
            AllHelper.TransformToCorrectTextColor(nail.Color);
            Console.Write($" {nail.RightOrLeft} {nail.TypeOfFingerOrToe} nail. Old length: {nail.CurrentLength:F1} mm.\n");
        }

        public static void PrintClippedToeNail(Person person, string staffName, Nail nail)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(staffName);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($" just clipped {person.Name}'s ");
            AllHelper.TransformToCorrectTextColor(nail.Color);
            Console.Write($" {nail.RightOrLeft} {nail.TypeOfFingerOrToe} nail. Old length: {nail.CurrentLength:F1} mm.\n");
        }

        public static void PrintClippedHair(Person person, string staffName)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(staffName);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($" just clipped {person.Name}'s hair to a length of {person.PrefferedHairLength:F1} cm. Old length was {person.Hair.HairLength:F1} cm.");
        }
    }
}
