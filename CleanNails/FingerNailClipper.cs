using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanNails
{
    internal class FingerNailClipper : IClipHandler
    {
        private List<Person> customers;
        private float preferredLength;

        public FingerNailClipper(List<Person> customers)
        {
            this.customers = customers;
        }

        public void Clip()
        {
            foreach (var person in customers)            
            {                  
                List<Nail> nails = person.GetLongFingerNails();
                int counter = 0;

                foreach (Nail nail in nails)
                {
                    Console.WriteLine($"{person.Name}'s {nail.Color} nail on {nail.RightOrLeft} {nail.TypeOfFingerOrToe} is {nail.CurrentLength:F1} mm long");

                    nail.CurrentLength = person.PreferredNailLength;

                    Console.WriteLine($"{person.Name}'s {nail.Color} nail on {nail.RightOrLeft} {nail.TypeOfFingerOrToe} is {nail.CurrentLength:F1} mm long");
                    counter++;
                }

                Console.WriteLine($"Clipped total of {counter} nails for {person.Name}\n");
            }
        }
        public bool ShouldClip()
        {
            foreach (var person in customers)
            {
                if(person.IsNailsToLong()) 
                { 
                    return true; 
                }               
            }
            return false;
        }
    }
}
