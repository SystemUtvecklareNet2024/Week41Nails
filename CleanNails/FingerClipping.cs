using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanNails
{
    internal class FingerClipping : INailHandler
    {    
        List<Person> persons;

        public FingerClipping(List<Person> persons)
        {
            this.persons = persons;
        }

        public void ClipNails()
        {               
            foreach (var person in persons)
            {
                foreach (var fingerNail in person.FingerNails)
                {
                    fingerNail.CurrentLength = person.PreferredNailLength;
                }
            }
        }

        public bool ShouldClip()
        {
            foreach (var person in persons)
            {

            }
            return persons.
        }
    }
}
