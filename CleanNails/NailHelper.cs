using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanNails
{
    internal static class NailHelper
    {
        public static List<Nail> GetFingerNails()
        {
            Random randLength = new Random();
            float dailyGrowRate = 0.1f;

            List<Nail> nails = new List<Nail>
            {
                // Right Hand
                 new Nail(GetNailColor(), TypeOfFingerOrToe.Thumb, RightOrLeft.Right, randLength.NextSingle(), dailyGrowRate),
                 new Nail(GetNailColor(), TypeOfFingerOrToe.IndexFinger, RightOrLeft.Right, randLength.NextSingle(), dailyGrowRate),
                 new Nail(GetNailColor(), TypeOfFingerOrToe.MiddleFinger, RightOrLeft.Right, randLength.NextSingle(), dailyGrowRate),
                 new Nail(GetNailColor(), TypeOfFingerOrToe.RingFinger, RightOrLeft.Right, randLength.NextSingle(), dailyGrowRate),
                 new Nail(GetNailColor(), TypeOfFingerOrToe.LittleFinger, RightOrLeft.Right, randLength.NextSingle(), dailyGrowRate),

                 // Left Hand
                 new Nail(GetNailColor(), TypeOfFingerOrToe.Thumb, RightOrLeft.Left, randLength.NextSingle(), dailyGrowRate),
                 new Nail(GetNailColor(), TypeOfFingerOrToe.IndexFinger, RightOrLeft.Left, randLength.NextSingle(), dailyGrowRate),
                 new Nail(GetNailColor(), TypeOfFingerOrToe.MiddleFinger, RightOrLeft.Left, randLength.NextSingle(), dailyGrowRate),
                 new Nail(GetNailColor(), TypeOfFingerOrToe.RingFinger, RightOrLeft.Left, randLength.NextSingle(), dailyGrowRate),
                 new Nail(GetNailColor(), TypeOfFingerOrToe.LittleFinger, RightOrLeft.Left, randLength.NextSingle(), dailyGrowRate),
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
                 new Nail(GetNailColor(), TypeOfFingerOrToe.BigToe, RightOrLeft.Right, randLength.NextSingle(), randLength.NextSingle(), dailyGrowRate ),
                 new Nail(GetNailColor(), TypeOfFingerOrToe.IndexToe, RightOrLeft.Right, randLength.NextSingle(), randLength.NextSingle(), dailyGrowRate),
                 new Nail(GetNailColor(), TypeOfFingerOrToe.MiddleToe, RightOrLeft.Right, randLength.NextSingle(), randLength.NextSingle(), dailyGrowRate),
                 new Nail(GetNailColor(), TypeOfFingerOrToe.FourthToe, RightOrLeft.Right, randLength.NextSingle(), randLength.NextSingle(), dailyGrowRate),
                 new Nail(GetNailColor(), TypeOfFingerOrToe.PinkyToe, RightOrLeft.Right, randLength.NextSingle(), randLength.NextSingle(), dailyGrowRate),

                 // Left Foot
                 new Nail(GetNailColor(), TypeOfFingerOrToe.BigToe, RightOrLeft.Left, randLength.NextSingle(), randLength.NextSingle(), dailyGrowRate),
                 new Nail(GetNailColor(), TypeOfFingerOrToe.IndexToe, RightOrLeft.Left, randLength.NextSingle(), randLength.NextSingle(), dailyGrowRate),
                 new Nail(GetNailColor(), TypeOfFingerOrToe.MiddleToe, RightOrLeft.Left, randLength.NextSingle(), randLength.NextSingle(), dailyGrowRate),
                 new Nail(GetNailColor(), TypeOfFingerOrToe.FourthToe, RightOrLeft.Left, randLength.NextSingle(), randLength.NextSingle(), dailyGrowRate),
                 new Nail(GetNailColor(), TypeOfFingerOrToe.PinkyToe, RightOrLeft.Left, randLength.NextSingle(), randLength.NextSingle(), dailyGrowRate),
            };

            return nails;
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
