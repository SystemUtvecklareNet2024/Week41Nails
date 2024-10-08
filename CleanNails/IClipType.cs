using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanNails
{
    internal interface IClipType
    {        
        bool ShouldClip(Person person);
        void Clip(Person person);
    }
}
