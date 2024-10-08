using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CleanNails
{
    internal class NailSaloon
    {
        public string SaloonName { get; set; }

        private List<Person> customers;

        private Staff pablo;
        private Staff pablina;

        public NailSaloon(string saloonName)
        {
            this.SaloonName = saloonName;
            this.customers = new List<Person>();

            pablo = new Staff(new NailClipper(), "Sir Pablo");
            pablina = new Staff(new HairClipper(), "Miss Pablina");
        }

        public void CheckAndClipNails()
        {
            foreach (Person person in customers)
            {
                if (pablo.ShouldClip(person))
                {
                    pablo.Clip(person);
                }
            }            
        }

        public void CheckAndClipHair()
        {
            foreach (Person person in customers)
            {
                if (pablina.ShouldClip(person))
                {
                    pablina.Clip(person);
                    Console.WriteLine($"{pablina.Name} just clipped {person.Name}'s hair to a length of {person.PrefferedHairLength} cm");
                }
            }
        }

        public void ChangeColorOfNails(int id)
        {
            Person customer = GetValidCustomerById(id);            
        }

        public void CreateCustomer(string name, float preferredNailLength)
        {
            Person customer = new Person(name, preferredNailLength, GenerateValidId());
            customers.Add(customer);
        }

        public bool DeleteCustomer(int id)
        {
            Person person = GetValidCustomerById(id);

            if (person != null)
            {
                customers.Remove(person);
                return true;
            }
            return false;
        }

        public List<Person> GetAllCustomers()
        {
            return customers;
        }

        public Person GetValidCustomerById(int id)
        {
            foreach (Person person in customers)
            {
                if(person.Id == id)
                {
                    return person;
                }
            }
            return null;
        }

        private int GenerateValidId()
        {
            int id = 0;
            foreach(Person person in customers)
            {
                if (id <= person.Id)
                {
                    id = person.Id;
                }
            }
            return id + 1;
        }

    }
}
