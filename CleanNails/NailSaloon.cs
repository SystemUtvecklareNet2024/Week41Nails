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
        private List<Person> customers;

        private FingerNailClipper fingerNailClipperAddon;
        private ClippingHandler nailClipper;


        public NailSaloon(string saloonName)
        {
            this.SaloonName = saloonName;
            this.customers = new List<Person>();

            fingerNailClipperAddon = new FingerNailClipper(customers);
            nailClipper = new ClippingHandler(fingerNailClipperAddon);

            Person person = new Person("Robert", 0.3f);
            Person person1 = new Person("Jelah", 0.3f);
            customers.Add(person);
            customers.Add(person1);
        }

        public void CheckAndClipNails()
        {
            foreach (Person person in customers)
            {
                if(nailClipper.ShouldClip())
                {
                    nailClipper.ClipNails();
                }              
            }
        }

        public void CreateNewCustomer(string name, float preferredNailLength)
        {
            Person customer = new Person(name, preferredNailLength);
            customers.Add(customer);
        }

        public List<Person> GetAllCustomers()
        {
            return customers;
        }

    }
}
