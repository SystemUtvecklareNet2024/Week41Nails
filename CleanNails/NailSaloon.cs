using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanNails
{
    internal class NailSaloon
    {
        public string SaloonName { get; set; }
        public List<Person> customers { get; set; }

        public NailSaloon(string saloonName)
        {
            this.SaloonName = saloonName;
            this.customers = new List<Person>();
        }

        public void CheckAndClipNails()
        {
            foreach (Person person in customers)
            {

            }
        }

    }
}
