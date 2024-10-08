using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanNails.HelperClasses;

namespace CleanNails
{
    internal class Person
    {
        public string Name { get; set; }
        public float PreferredNailLength { get; set; }
        public List<Nail> FingerNails { get; }
        public List<Nail> ToeNails { get; }

        public Person(string name, float preferredNailLength)
        {
            this.Name = name;
            this.PreferredNailLength = preferredNailLength;
            this.FingerNails = NailHelper.GetFingerNails();
            this.ToeNails = NailHelper.GetToeNails();
        }

        public bool IsNailsToLong()
        {
            var nails = FingerNails.Where(n => n.CurrentLength >= PreferredNailLength + 2.0f);
            
            if (nails.Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Nail> GetLongFingerNails()
        {
            List<Nail> nails = new List<Nail>();

            foreach (var nail in FingerNails)
            {
                if(nail.CurrentLength >= PreferredNailLength + 2.0f)
                {
                    nails.Add(nail);
                }
            }
            return nails;
        }

    }
}
