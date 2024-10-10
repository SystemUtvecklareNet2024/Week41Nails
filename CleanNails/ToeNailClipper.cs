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

            foreach (Nail nail in person.GetLongToeNails())
            {
                Printer.PrintClippedToeNail(person, staffName, nail);
                nail.CurrentLength = person.PreferredNailLength;
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
