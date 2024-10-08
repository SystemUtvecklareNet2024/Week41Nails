using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanNails
{
    internal class Hair
    {
        public float HairLength { get; set; }
        public float GrowRate { get; set; }

        public Hair(float hairLength, float growRate)
        {
            GrowRate = growRate;
            HairLength = hairLength;
        }

        public void Grow()
        {
            HairLength += GrowRate;
        }

    }
}
