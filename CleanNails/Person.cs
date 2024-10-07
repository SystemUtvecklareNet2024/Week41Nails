using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanNails
{
    internal class Person
    {        
        public string Name { get; set; }
        public List<Nail> FingerNails { get; set; }
        public List<Nail> ToeNails { get; set; }

        public Person(string name)
        {
            Name = name;
            FingerNails = NailHelper.GetFingerNails();
            ToeNails = NailHelper.GetToeNails();
        }

        public List<Nail> IsNailToLong()
        {
            // return all nails which are to long.
        }
    }
}
