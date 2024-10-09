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
        public int Id { get; set; }
        public float PreferredNailLength { get; set; }
        public float PrefferedHairLength { get; set; }
        public Hair Hair { get; set; }
        public List<Nail> FingerNails { get; }
        public List<Nail> ToeNails { get; }

        public Person(string name, float preferredNailLength, float preferredHairLength, int id)
        {
            this.Hair = AllHelper.NewHair();
            this.Name = name;
            this.PreferredNailLength = preferredNailLength;
            this.PrefferedHairLength = preferredHairLength;
            this.FingerNails = AllHelper.GetFingerNails();
            this.ToeNails = AllHelper.GetToeNails();
            this.Id = id;
        }

        public bool IsFingerNailsToLong()
        {
            var fNails = FingerNails.Where(n => n.CurrentLength >= PreferredNailLength + 2.0f);            
            
            if (fNails.Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsToeNailsToLong()
        {
            var tNails = ToeNails.Where(n => n.CurrentLength >= PreferredNailLength + 2.0f);

            if(tNails.Count() > 0)
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

        public List<Nail> GetLongToeNails()
        {
            List<Nail> nails = new List<Nail>();

            foreach (var nail in ToeNails)
            {
                if (nail.CurrentLength >= PreferredNailLength + 2.0f)
                {
                    nails.Add(nail);
                }
            }
            return nails;
        }

        private double GetAverageNailLength()
        {
            double averageValue = 0;

            foreach (var nail in ToeNails) { averageValue += nail.CurrentLength; }
            foreach (var nail in FingerNails) { averageValue += nail.CurrentLength; }

            return averageValue / (ToeNails.Count() + FingerNails.Count());
        }

        public override string ToString()
        {
            return $"{Id.ToString().PadRight(11)} {Name.PadRight(19)} {Hair.HairLength:F1} cm\t\t {GetAverageNailLength():F1} mm";
        }
    }
}
