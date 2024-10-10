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
            foreach (Nail nail in person.GetLongFingerNails())
            {
                Printer.PrintClippedFingerNail(person, staffName, nail);
                nail.CurrentLength = person.PreferredNailLength;
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
