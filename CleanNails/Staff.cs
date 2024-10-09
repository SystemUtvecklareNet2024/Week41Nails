using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanNails.Interfaces;

namespace CleanNails
{
    internal class Staff
    {        
        private IClipType _typeOfClipper;
        public string Name { get; set; }

        public Staff(IClipType handler, string name)
        {
            this._typeOfClipper = handler;
            Name = name;
        }

        public void Clip(Person person)
        {
            _typeOfClipper.Clip(person, Name);            
        }

        public bool ShouldClip(Person person)
        {
            return _typeOfClipper.ShouldClip(person);
        }
    }
}
