using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanNails
{
    internal interface INailHandler
    {
        bool ShouldClip();
        void ClipNails();
    }
}
