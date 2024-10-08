using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanNails
{
    internal class HairClipper : IClipType
    {
        public void Clip(Person person)
        {
            person.Hair.HairLength = person.PrefferedHairLength;
        }

        public bool ShouldClip(Person person)
        {
            if (person.Hair.HairLength >= person.PrefferedHairLength + 10.0f)
            {
                return true;
            }
            return false;
        }
    }
}
