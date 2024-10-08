using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanNails.Enum;

namespace CleanNails.HelperClasses
{
    internal static class AllGodHelper
    {
        public static List<Nail> GetFingerNails()
        {
            Random randLength = new Random();
            Random randGrow = new();

            float dailyGrowRate = 0.1f;

            List<Nail> nails = new List<Nail>
            {
                // Right Hand
                 new Nail(1, GetNailColor(), TypeOfFingerOrToe.Thumb, RightOrLeft.Right, randLength.NextSingle(), dailyGrowRate),
                 new Nail(2, GetNailColor(), TypeOfFingerOrToe.IndexFinger, RightOrLeft.Right, randLength.NextSingle(), dailyGrowRate),
                 new Nail(3, GetNailColor(), TypeOfFingerOrToe.MiddleFinger, RightOrLeft.Right, randLength.NextSingle(), dailyGrowRate),
                 new Nail(4, GetNailColor(), TypeOfFingerOrToe.RingFinger, RightOrLeft.Right, randLength.NextSingle(), dailyGrowRate),
                 new Nail(5, GetNailColor(), TypeOfFingerOrToe.LittleFinger, RightOrLeft.Right, randLength.NextSingle(), dailyGrowRate),

                 // Left Hand
                 new Nail(6, GetNailColor(), TypeOfFingerOrToe.Thumb, RightOrLeft.Left, randLength.NextSingle(), dailyGrowRate),
                 new Nail(7, GetNailColor(), TypeOfFingerOrToe.IndexFinger, RightOrLeft.Left, randLength.NextSingle(), dailyGrowRate),
                 new Nail(8, GetNailColor(), TypeOfFingerOrToe.MiddleFinger, RightOrLeft.Left, randLength.NextSingle(), dailyGrowRate),
                 new Nail(9, GetNailColor(), TypeOfFingerOrToe.RingFinger, RightOrLeft.Left, randLength.NextSingle(), dailyGrowRate),
                 new Nail(10, GetNailColor(), TypeOfFingerOrToe.LittleFinger, RightOrLeft.Left, randLength.NextSingle(), dailyGrowRate),
            };

            return nails;
        }

        public static List<Nail> GetToeNails()
        {
            Random randLength = new Random();
            float dailyGrowRate = 0.1f;

            List<Nail> nails = new List<Nail>
            {
                // Right Foot
                 new Nail(1, GetNailColor(), TypeOfFingerOrToe.BigToe, RightOrLeft.Right, randLength.NextSingle(), dailyGrowRate ),
                 new Nail(2, GetNailColor(), TypeOfFingerOrToe.IndexToe, RightOrLeft.Right, randLength.NextSingle(), dailyGrowRate),
                 new Nail(3, GetNailColor(), TypeOfFingerOrToe.MiddleToe, RightOrLeft.Right, randLength.NextSingle(), dailyGrowRate),
                 new Nail(4, GetNailColor(), TypeOfFingerOrToe.FourthToe, RightOrLeft.Right, randLength.NextSingle(), dailyGrowRate),
                 new Nail(5, GetNailColor(), TypeOfFingerOrToe.PinkyToe, RightOrLeft.Right, randLength.NextSingle(), dailyGrowRate),

                 // Left Foot
                 new Nail(6, GetNailColor(), TypeOfFingerOrToe.BigToe, RightOrLeft.Left, randLength.NextSingle(), dailyGrowRate),
                 new Nail(7, GetNailColor(), TypeOfFingerOrToe.IndexToe, RightOrLeft.Left, randLength.NextSingle(), dailyGrowRate),
                 new Nail(8, GetNailColor(), TypeOfFingerOrToe.MiddleToe, RightOrLeft.Left, randLength.NextSingle(), dailyGrowRate),
                 new Nail(9, GetNailColor(), TypeOfFingerOrToe.FourthToe, RightOrLeft.Left, randLength.NextSingle(), dailyGrowRate),
                 new Nail(10, GetNailColor(), TypeOfFingerOrToe.PinkyToe, RightOrLeft.Left, randLength.NextSingle(), dailyGrowRate),

                
            };

            foreach (var item in nails)
            {
                Console.WriteLine(item.CurrentLength);
            }

            return nails;
        }

        public static Hair NewHair()
        {
            float growRate = 0.4f;
            return new Hair(5.0f, growRate);
        }

        private static string GetNailColor()
        {
            Random rand = new Random();

            List<string> nailColor = new List<string>
            {
                "Black", "Yellow", "Orange", "Blue", "Red", "Pink", "Purple", "White", "Green", "Brown"
            };

            return nailColor[rand.Next(0, nailColor.Count())];
        }

    }
}
