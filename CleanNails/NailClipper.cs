using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanNails.Interfaces;

namespace CleanNails
{
    internal class NailClipper : IClipType
    {
        public void Clip(Person person)
        {
            int counter = 0;

            foreach (Nail nail in person.GetLongFingerNails())
            {
                //Console.WriteLine($"{person.Name}'s {nail.Color} nail on {nail.RightOrLeft} {nail.TypeOfFingerOrToe} is {nail.CurrentLength:F1} mm long");

                nail.CurrentLength = person.PreferredNailLength;

                //Console.WriteLine($"{person.Name}'s {nail.Color} nail on {nail.RightOrLeft} {nail.TypeOfFingerOrToe} is {nail.CurrentLength:F1} mm long");
                counter++;
            }
            //Console.WriteLine($"Clipped total of {counter} nails for {person.Name}\n");
        }

        public bool ShouldClip(Person person)
        {
            if (person.IsNailsToLong())
            {
                return true;
            }

            return false;
        }
    }
}
