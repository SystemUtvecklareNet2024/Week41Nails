using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanNails
{
    internal class Staff
    {
        public string Name { get; set; }
        private IClipType typeOfClipper;

        public Staff(IClipType handler, string name)
        {
            this.typeOfClipper = handler;
            Name = name;
        }

        public void Clip(Person person)
        {
            typeOfClipper.Clip(person);            
        }

        public bool ShouldClip(Person person)
        {
            return person.IsNailsToLong(); 
        }
    }
}
