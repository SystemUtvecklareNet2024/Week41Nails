using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanNails
{
    internal class NailSaloon
    {
        private NailClipper clipper;
        public List<Person> customers { get; set; }

        public NailSaloon()
        {
            customers = new List<Person>();
            clipper = new NailClipper();
        }

        
    }
}
