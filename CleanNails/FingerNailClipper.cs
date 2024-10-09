using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanNails.HelperClasses;
using CleanNails.Interfaces;

namespace CleanNails
{
    internal class FingerNailClipper : IClipType
    {
        public void Clip(Person person, string staffName)
        {
            int counter = 0;

            foreach (Nail nail in person.GetLongFingerNails())
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(staffName);
                Console.ForegroundColor= ConsoleColor.White;
                Console.Write($" just clipped {person.Name}'s ");
                AllHelper.TransformToCorrectTextColor(nail.Color);
                Console.Write($" {nail.RightOrLeft} {nail.TypeOfFingerOrToe} nail. Old length: {nail.CurrentLength:F1} mm.\n");

                nail.CurrentLength = person.PreferredNailLength;                

                counter++;
            }
        }

        public bool ShouldClip(Person person)
        {
            if (person.IsFingerNailsToLong())
            {
                return true;
            }

            return false;
        }
    }
}
