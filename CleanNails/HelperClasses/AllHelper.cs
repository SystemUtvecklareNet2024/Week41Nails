using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanNails.Enum;

namespace CleanNails.HelperClasses
{
    internal static class AllHelper
    {
        public static List<Nail> GetFingerNails()
        {
            Random randLength = new Random();
            Random dailyGrowRate = new();

            List<Nail> nails = new List<Nail>
            {
                // Right Hand
                 new Nail(1, GetNailColor(), TypeOfFingerOrToe.Thumb, RightOrLeft.Right, randLength.NextSingle() * 3, dailyGrowRate.NextSingle()),
                 new Nail(2, GetNailColor(), TypeOfFingerOrToe.IndexFinger, RightOrLeft.Right, randLength.NextSingle() * 3, dailyGrowRate.NextSingle()),
                 new Nail(3, GetNailColor(), TypeOfFingerOrToe.MiddleFinger, RightOrLeft.Right, randLength.NextSingle() * 3, dailyGrowRate.NextSingle()),
                 new Nail(4, GetNailColor(), TypeOfFingerOrToe.RingFinger, RightOrLeft.Right, randLength.NextSingle() * 3, dailyGrowRate.NextSingle()),
                 new Nail(5, GetNailColor(), TypeOfFingerOrToe.LittleFinger, RightOrLeft.Right, randLength.NextSingle() * 3, dailyGrowRate.NextSingle()),

                 // Left Hand
                 new Nail(6, GetNailColor(), TypeOfFingerOrToe.Thumb, RightOrLeft.Left, randLength.NextSingle() * 3, dailyGrowRate.NextSingle()),
                 new Nail(7, GetNailColor(), TypeOfFingerOrToe.IndexFinger, RightOrLeft.Left, randLength.NextSingle() * 3, dailyGrowRate.NextSingle()),
                 new Nail(8, GetNailColor(), TypeOfFingerOrToe.MiddleFinger, RightOrLeft.Left, randLength.NextSingle() * 3, dailyGrowRate.NextSingle()),
                 new Nail(9, GetNailColor(), TypeOfFingerOrToe.RingFinger, RightOrLeft.Left, randLength.NextSingle() * 3, dailyGrowRate.NextSingle()),
                 new Nail(10, GetNailColor(), TypeOfFingerOrToe.LittleFinger, RightOrLeft.Left, randLength.NextSingle() * 3, dailyGrowRate.NextSingle()),
            };

            return nails;
        }

        public static List<Nail> GetToeNails()
        {
            Random randLength = new Random();
            Random dailyGrowRate = new();

            List<Nail> nails = new List<Nail>
            {
                // Right Foot
                 new Nail(1, GetNailColor(), TypeOfFingerOrToe.BigToe, RightOrLeft.Right, randLength.NextSingle() * 3, dailyGrowRate.NextSingle()),
                 new Nail(2, GetNailColor(), TypeOfFingerOrToe.IndexToe, RightOrLeft.Right, randLength.NextSingle() * 3, dailyGrowRate.NextSingle()),
                 new Nail(3, GetNailColor(), TypeOfFingerOrToe.MiddleToe, RightOrLeft.Right, randLength.NextSingle() * 3, dailyGrowRate.NextSingle()),
                 new Nail(4, GetNailColor(), TypeOfFingerOrToe.FourthToe, RightOrLeft.Right, randLength.NextSingle() * 3, dailyGrowRate.NextSingle()),
                 new Nail(5, GetNailColor(), TypeOfFingerOrToe.PinkyToe, RightOrLeft.Right, randLength.NextSingle() * 3, dailyGrowRate.NextSingle()),

                 // Left Foot
                 new Nail(6, GetNailColor(), TypeOfFingerOrToe.BigToe, RightOrLeft.Left, randLength.NextSingle() * 3, dailyGrowRate.NextSingle()),
                 new Nail(7, GetNailColor(), TypeOfFingerOrToe.IndexToe, RightOrLeft.Left, randLength.NextSingle() * 3, dailyGrowRate.NextSingle()),
                 new Nail(8, GetNailColor(), TypeOfFingerOrToe.MiddleToe, RightOrLeft.Left, randLength.NextSingle() * 3, dailyGrowRate.NextSingle()),
                 new Nail(9, GetNailColor(), TypeOfFingerOrToe.FourthToe, RightOrLeft.Left, randLength.NextSingle() * 3, dailyGrowRate.NextSingle()),
                 new Nail(10, GetNailColor(), TypeOfFingerOrToe.PinkyToe, RightOrLeft.Left, randLength.NextSingle() * 3, dailyGrowRate.NextSingle()),                
            };            

            return nails;
        }

        public static Hair NewHair()
        {
            Random rand = new Random();
            return new Hair((float)rand.Next(0, 10), rand.NextSingle());
        }

        private static string GetNailColor()
        {
            Random rand = new Random();

            List<string> nailColor = new List<string>
            {
                "Black", "Yellow", "Orange", "Blue", "Red", "Pink", "Purple", "White", "Green"
            };

            return nailColor[rand.Next(0, nailColor.Count())];
        }

        public static void TransformToCorrectTextColor(string colorString)
        {
            if(colorString == "Black")
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(colorString);
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (colorString == "Yellow")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(colorString);
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (colorString == "Orange")
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(colorString);
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (colorString == "Blue")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(colorString);
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (colorString == "Red")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(colorString);
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (colorString == "Pink")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(colorString);
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (colorString == "Purple")
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write(colorString);
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (colorString == "White")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(colorString);
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (colorString == "Green")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(colorString);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

    }
}
