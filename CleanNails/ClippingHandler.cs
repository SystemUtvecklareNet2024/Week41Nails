using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanNails
{
    internal class ClippingHandler
    {
        private IClipHandler nailHandler;

        public ClippingHandler(IClipHandler handler)
        {
            this.nailHandler = handler;
        }

        public void ClipNails()
        {
            nailHandler.Clip();            
        }

        public bool ShouldClip()
        {
            return nailHandler.ShouldClip(); 
        }
    }
}
