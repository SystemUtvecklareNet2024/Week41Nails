using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanNails.Interfaces;

namespace CleanNails
{
    internal class HairClipper : IClipType
    {
        public void Clip(Person person, string staffName)
        {            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(staffName);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($" just clipped {person.Name}'s hair to a length of {person.PrefferedHairLength:F1} cm. Old length was {person.Hair.HairLength:F1} cm.");

            person.Hair.HairLength = person.PrefferedHairLength;
        }

        public bool ShouldClip(Person person)
        {
            if (person.Hair.HairLength >= person.PrefferedHairLength + 5.0f)
            {
                return true;
            }
            return false;
        }
    }
}
