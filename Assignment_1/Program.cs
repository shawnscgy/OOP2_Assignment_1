using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyModernAppliances m1 = new MyModernAppliances();
            // Load file, get a list of all appliances
            List<Appliance> list = m1.ReadAppliances();
            string inputOption = m1.DisplayMenu();
            bool quit = false;
            while (quit == false)
            {

                switch (inputOption)
                {
                    // Checkout
                    case "1":
                        Appliance intendedApp = m1.Find(list);
                        if (intendedApp == null)
                        {
                            Console.WriteLine("No appliances found with that item number.");
                            Console.WriteLine();
                        }
                        else
                        {
                            m1.Checkout(intendedApp);
                        }
                        break;
                    // Search by brand
                    case "2":
                        m1.SearchByBrand(list);
                        break;
                    // Display by type
                    case "3":
                        m1.DisplayAppliancesByType(list);
                        break;
                    // Random
                    case "4":
                        List<int> indexes = m1.RandomList(list);
                        RandomComparer.Comparer(indexes, list);
                        break;
                    // Save & exit
                    case "5":
                        m1.Save(list);
                        quit = true;
                        break;
                }

                inputOption = m1.DisplayMenu();
            }
        }
    }
}
