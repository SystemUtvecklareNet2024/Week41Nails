using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanNails.HelperClasses;

namespace CleanNails
{
    internal class AppManager
    {
        private NailSaloon nailSaloon;

        public AppManager(NailSaloon nailSaloon)
        {
            this.nailSaloon = nailSaloon;
        }

        public void Menu()
        {
            SimulateDays(20);
            nailSaloon.CheckAndClipNails();
        }

        private void SimulateDays(int days)
        {
            for (int i = 1; i <= days; i++)
            {
                Console.WriteLine("Day" + i);

                foreach (var customer in nailSaloon.GetAllCustomers())
                {
                    foreach (var nail in customer.ToeNails)
                    {
                        nail.Grow();                        
                    }                   

                    foreach (var nail in customer.FingerNails)
                    {
                        nail.Grow();                        
                    }                    
                }
                nailSaloon.CheckAndClipNails();
            }
        }
    }
}

