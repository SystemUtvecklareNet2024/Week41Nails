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
        public float PreferredNailLength { get; set; }
        public List<Nail> FingerNails { get; set; }
        public List<Nail> ToeNails { get; set; }

        public Person(string name, float preferredNailLength)
        {
            this.Name = name;
            this.PreferredNailLength = preferredNailLength;
            this.FingerNails = NailHelper.GetFingerNails();
            this.ToeNails = NailHelper.GetToeNails();
        }

        public bool IsNailToLong()
        {
            var nails = FingerNails.Where(n => n.CurrentLength == PreferredNailLength + 2.0f);
            if (nails.Count() > 0) { return false; }
            else { return true; }
        }

    }
}
