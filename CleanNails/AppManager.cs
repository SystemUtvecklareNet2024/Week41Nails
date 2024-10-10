using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
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
        public void Run()
        {
            Printer.MenuChoice(nailSaloon.SaloonName);
            ChoiceHandler(Console.ReadLine());
        }

        public void ChoiceHandler(string? input)
        {
            switch (input)
            {
                case "1":
                    CreateCustomer();
                    break;
                case "2":
                    DeleteCustomer();
                    break;
                case "3":
                    ListAllCustomers();
                    Run();
                    break;
                case "4":
                    ChangePreferredLength();
                    break;
                case "5":
                    SimulateDays();
                    break;
                case "6":
                    break;
                default:
                    Run();
                    break;
            }
        }

        private void CreateCustomer()
        {
            Console.Write("\nName: ");
            string? name = Console.ReadLine();
            Console.Write("Preferred naillength in mm: ");
            float nailLength = ReadFloatInput();
            Console.Write("Preferred hairlength in cm: ");
            float hairLength = ReadFloatInput();

            if(name!= null && nailLength != 0 && hairLength != 0)
                nailSaloon.CreateCustomer(name, nailLength, hairLength);

            Console.WriteLine("\nCreate success, press enter to continue");
            Console.ReadLine();

            Run();
        }

        private void DeleteCustomer()
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
            Run();
        }

        private void ListAllCustomers()
        {
            Console.Clear();
            Console.WriteLine("{0,-12}{1, -20}{2, -17}{3, -12}", "ID", "Name", "HairLength", "Average Naillength");
            foreach (var person in nailSaloon.GetAllCustomers())
            {
                Console.WriteLine(person);

                Console.WriteLine("---- FingerNails ----");
                foreach (var nail in person.FingerNails)
                {
                    Console.WriteLine($"{nail.RightOrLeft} {nail.TypeOfFingerOrToe.ToString().PadRight(12)}\tCurrLength: {nail.CurrentLength:F1}\t PreffLength: {person.PreferredNailLength:F1}\t Growrate: {nail.DailyGrowRate:F1}");
                }
                Console.WriteLine("---- ToeNails ----");
                foreach (var nail in person.ToeNails)
                {
                    Console.WriteLine($"{nail.RightOrLeft} {nail.TypeOfFingerOrToe.ToString().PadRight(12)}\tCurrLength: {nail.CurrentLength:F1}\t PreffLength: {person.PreferredNailLength:F1}\t Growrate: {nail.DailyGrowRate:F1}");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
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

                Console.Write("New preferred nail Length: ");

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
            Run();
        }

        private void SimulateDays()
        {
            Console.Clear();

            Console.Write("\nDays to Simulate: ");

            int numDays;
            if (int.TryParse(Console.ReadLine(), out numDays))
            {
                for (int i = 1; i <= numDays; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nDay " + i);
                    Console.ForegroundColor = ConsoleColor.White;

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

                    nailSaloon.CheckAndClipFingerNails();
                    nailSaloon.CheckAndClipToeNails();
                    nailSaloon.CheckAndClipHair();
                }
            }
            Console.WriteLine("\nPress enter to return to menu");
            Console.ReadLine();
            Run();
        }

        public int ReadInput() 
        {
            int result;
            if (int.TryParse(Console.ReadLine(), out result)) 
            {
                return result;
            }
            else
            {
                Console.WriteLine("Invalid number");
                Console.ReadLine();

            }
            Run();
            return result;
        }

        public float ReadFloatInput() { return float.Parse(Console.ReadLine()); }
    }
}

