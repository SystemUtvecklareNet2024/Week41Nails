using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanNails
{
    internal class AppManager
    {
        private NailSaloon nailSaloon;

        public AppManager(NailSaloon nailSaloon)
        {
            this.nailSaloon = nailSaloon;
        }

        public void Menu()
        {

        }

        public void ClipNails()
        {
            throw new NotImplementedException();
        }

        public bool ShouldClip()
        {
            // Check if should clip
            throw new NotImplementedException();
        }
    }
}
