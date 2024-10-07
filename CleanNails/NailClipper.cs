using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanNails
{
    internal class NailClipper
    {
        public void ClipNail(Nail nail)
        {
            nail.CurrentLength = nail.PreferredLength;
        }
    }
}
