using CleanNails.HelperClasses;
using CleanNails.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanNails
{
    internal class ToeNailClipper : IClipType
    {
        public void Clip(Person person, string staffName)
        {
            int counter = 0;

            foreach (Nail nail in person.GetLongToeNails())
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(staffName);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($" just clipped {person.Name}'s ");
                AllHelper.TransformToCorrectTextColor(nail.Color);
                Console.Write($" {nail.RightOrLeft} {nail.TypeOfFingerOrToe} nail. Old length: {nail.CurrentLength:F1} mm.\n");
                nail.CurrentLength = person.PreferredNailLength;

                counter++;
            }
        }

        public bool ShouldClip(Person person)
        {
            if (person.IsToeNailsToLong())
            {
                return true;
            }

            return false;
        }
    }
}
