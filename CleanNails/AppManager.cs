using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
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
            Console.Clear();
            Console.WriteLine($"Welcome to {nailSaloon.SaloonName}");
            Console.WriteLine();
            Console.WriteLine("1. Create new customer");
            Console.WriteLine("2. Delete customer");
            Console.WriteLine("3. List all customers");
            Console.WriteLine("4. Change preferred length of nails");
            //Console.WriteLine("5. Change color of nails");
            Console.WriteLine("6. Simulate days");
            Console.WriteLine("7. Quit");

            Console.Write("\nEnter choice: ");
            ChoiceHandler(Console.ReadLine());

        }

        public void ChoiceHandler(string? input)
        {
            switch (input)
            {
                case "1":
                    // Create new Customer
                    Create();
                    break;

                case "2":
                    // Delete customer
                    Delete();
                    break;

                case "3":
                    // List all customers
                    ListAllCustomers();
                    Console.WriteLine("\nPress enter to continue...");
                    Console.ReadLine();
                    Menu();
                    break;

                case "4":
                    // Change preferred length
                    ChangePreferredLength();
                    break;

                case "5":
                    // Change color of Nails
                    break;

                case "6":
                    //Simulate Days
                    SimulateDays(20);
                    break;
                case "7":
                    //Quit
                    break;

                default:
                    Console.WriteLine("\nInvalid choice try again.");
                    Menu();
                    break;
            }
        }

        private void Create()
        {
            Console.Write("\nName: ");
            string? name = Console.ReadLine();

            if (name != null)
            {
                Console.Write("Preferred naillength: ");

                float nailLength;
                if (float.TryParse(Console.ReadLine(), out nailLength))
                {
                    nailSaloon.CreateCustomer(name, nailLength);
                    Console.WriteLine("\nCreate success, press enter to continue");
                }
                else
                {
                    Console.WriteLine("\nInvalid number, press enter to continue.. ");
                }
            }
            else
            {
                Console.WriteLine("\nInvalid name press enter to continue..");
            }
            Console.ReadLine();

            Menu();
        }

        private void Delete()
        {
            Console.Clear();
            ListAllCustomers();

            Console.Write("\nEnter ID to delete: ");
            int input = ReadInput();

            if (nailSaloon.DeleteCustomer(input))
            {
                Console.WriteLine("\nSuccessfully removed customer, press enter to continue");
            }
            else
            {
                Console.WriteLine("\nCustomer not found, press enter to continue");
            }

            Console.ReadLine();
            Menu();
        }

        private void ListAllCustomers()
        {
            Console.Clear();

            foreach (var person in nailSaloon.GetAllCustomers())
            {
                Console.WriteLine(person);
                foreach (var nail in person.FingerNails)
                {
                    Console.WriteLine(nail);
                }
            }
        }

        private void ChangePreferredLength()
        {
            Console.Clear();
            ListAllCustomers();

            Console.Write("\nEnter ID of customer: ");

            int input = ReadInput();

            if (nailSaloon.GetValidCustomerById(input) != null)
            {
                Person person = nailSaloon.GetValidCustomerById(input);

                Console.Write("New preferred Length: ");

                float nailLength;
                if (float.TryParse(Console.ReadLine(), out nailLength))
                {
                    person.PreferredNailLength = nailLength;
                    Console.WriteLine("\nNew length set...");
                }
                else
                {
                    Console.WriteLine("\nInvalid number, press enter to continue.. ");
                }
            }
            else
            {
                Console.WriteLine("\nCustomer not found, press enter to continue");
            }
            Console.ReadLine();
            Menu();
        }

        private void SimulateDays(int days)
        {
            Console.WriteLine();
            for (int i = 1; i <= days; i++)
            {
                Console.WriteLine("Day " + i);

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
                    customer.Hair.Grow();
                }
                nailSaloon.CheckAndClipNails();
                nailSaloon.CheckAndClipHair();
            }
            Console.ReadLine();
            Menu();
        }

        public int ReadInput()
        {
            int input;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out input))
                {
                    return input;
                }
                else
                {
                    Console.Write("\nInvalid input... try again: ");
                }
            }
        }
    }
}

