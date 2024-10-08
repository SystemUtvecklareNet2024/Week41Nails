using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanNails
{
    internal class ClippingHandler
    {
        INailHandler nailHandler;

        public ClippingHandler(INailHandler handler)
        {
            this.nailHandler = handler;
        }

        public void ClipNails()
        {
            nailHandler.ClipNails();
            
        }

        public bool ShouldClip()
        {
            // person.IsNailToLong();
            return nailHandler.ShouldClip(); 
        }
    }
}
