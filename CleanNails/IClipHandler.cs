using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanNails
{
    internal interface IClipHandler
    {
        bool ShouldClip();
        void Clip();
    }
}
