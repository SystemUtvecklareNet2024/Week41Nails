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

        private List<Person> _customers;

        private Staff pablo;
        private Staff pablina;
        private Staff miguel;

        public NailSaloon(string saloonName)
        {
            this.SaloonName = saloonName;
            this._customers = new List<Person>();

            pablo = new Staff(new FingerNailClipper(), "Sir Pablo");
            pablina = new Staff(new HairClipper(), "Miss Pablina");
            miguel = new Staff(new ToeNailClipper(), "Sir Miguel");
        }

        #region CheckAndClip
        public void CheckAndClipFingerNails()
        {
            foreach (Person person in _customers)
            {
                if (pablo.ShouldClip(person))
                {
                    pablo.Clip(person);                    
                }
            }            
        }

        public void CheckAndClipToeNails()
        {
            foreach (var person in _customers)
            {
                if(miguel.ShouldClip(person))
                {
                    miguel.Clip(person);                    
                }
            }
        }

        public void CheckAndClipHair()
        {
            foreach (Person person in _customers)
            {
                if (pablina.ShouldClip(person))
                {
                    pablina.Clip(person);
                    
                }
            }
        }
        #endregion

        #region CreateAndDelete
        public void CreateCustomer(string name, float preferredNailLength, float preferredHairLength)
        {
            Person customer = new Person(name, preferredNailLength, preferredHairLength, GenerateValidId());
            _customers.Add(customer);
        }

        public bool DeleteCustomer(int id)
        {
            Person person = GetValidCustomerById(id);

            if (person != null)
            {
                _customers.Remove(person);
                return true;
            }
            return false;
        }

        #endregion

        #region Helpers
        public List<Person> GetAllCustomers()
        {
            return _customers;
        }

        public Person GetValidCustomerById(int id)
        {            
            return _customers.Where(p => p.Id == id).First();
        }

        private int GenerateValidId()
        {
            int id = 0;
            foreach(Person person in _customers)
            {
                if (id <= person.Id)
                {
                    id = person.Id;
                }
            }
            return id + 1;
        }
        #endregion

    }
}
