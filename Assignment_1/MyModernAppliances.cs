using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using System.Diagnostics;
using System.Reflection;

namespace Assignment_1
{
    public class MyModernAppliances : IModernAppliances
    {

        //Display Menu
        public string DisplayMenu()
        {
            Console.WriteLine("Welcome to Modern Appliance!\n" +
                "How many we assist you?\n" +
                "1 - Check out appliance\n" +
                "2 - Find appliances by brand\n" +
                "3 - Display appliances by type\n" +
                "4 - Produce random appliance list\n" +
                "5 - Save & exit");
            Console.WriteLine("Enter option:");
            string inputOption = Console.ReadLine();
            return inputOption;
        }



        //----- Option 1 : Checkout -----//

        // Checkout
        public void Checkout(Appliance app)
        {
            if (app.Quantity == 0)
            {
                Console.WriteLine("The appliance is not available to be checked out.\n");
            }
            else
            {
                app.Quantity -= 1;
                Console.WriteLine("Appliance \"" + app.ItemNumber + "\" has been checked out.\n");
            }
        }
        // Find
        public Appliance Find(List<Appliance> list)
        {
            Console.WriteLine("Enter the item number of an appliance:");
            Appliance result;
            long inputItemNum = Convert.ToInt32(Console.ReadLine());
            result = list.Find(app => app.ItemNumber == inputItemNum);
            return result;
        }

        //----- Option 2 : Find -----//

        public void SearchByBrand(List<Appliance> list)
        {
            Console.WriteLine("Enter brand to search for:");
            string inputBran = Console.ReadLine();
            Console.WriteLine("Matching Appliances:");
            foreach (Appliance app in list)
            {
                if (inputBran == app.Brand)
                {
                    if (app is Refrigerator)
                    {
                        Console.WriteLine((Refrigerator)app);
                    }
                    else if (app is Vacuum)
                    {
                        Console.WriteLine((Vacuum)app);
                    }
                    else if (app is Microwave)
                    {
                        Console.WriteLine((Microwave)app);
                    }
                    else
                    {
                        Console.WriteLine((Dishwasher)app);
                    }
                    Console.WriteLine();
                }
            }
        }

        //-----  Option 3 : Display  ----- //

        // Display by Type
        public void DisplayAppliancesByType(List<Appliance> list)
        {
            Console.WriteLine("Appliance Types" +
                "\n1 – Refrigerators" +
                "\n2 – Vacuums" +
                "\n3 – Microwaves" +
                "\n4 – Dishwashers" +
                "\nEnter type of appliance:");
            string option = Console.ReadLine();
            switch (option)
            {
                // Refrigerator
                case "1":
                    DisplayRefrigerator(list);
                    break;
                // Vacuum
                case "2":
                    DisplayVacuum(list);
                    break;
                case "3":
                    DisplayMicrowave(list);
                    break;
                case "4":
                    DisplayDishwasher(list);
                    break;
            }
        }

        // DisplayRefrigerator
        public void DisplayRefrigerator(List<Appliance> list)
        {
            // Input door number
            Console.WriteLine("Enter number of doors: 2 (double door), 3 (three doors) or 4 (four doors):");
            int doorNum = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Matching refrigerators:");
            foreach (Appliance app in list)
            {
                if (app is Refrigerator && ((Refrigerator)app).Doors == doorNum)
                {
                    Console.WriteLine((Refrigerator)app);
                    Console.WriteLine();
                }
            }
        }

        //DisplayVacuum
        public void DisplayVacuum(List<Appliance> list)
        {
            Console.WriteLine("Enter battery voltage value. 18 V (low) or 24 V (high)");
            Console.WriteLine("Matching vacuums:");
            int inputVolt = Convert.ToInt16(Console.ReadLine());
            foreach (Appliance app in list)
            {
                // Is vacuum & = input
                if (app is Vacuum && ((Vacuum)app).BatteryVoltage == inputVolt)
                {
                    Console.WriteLine((Vacuum)app);
                    Console.WriteLine();
                }
            }
        }
        // DisplayMicrowave
        public void DisplayMicrowave(List<Appliance> list)
        {
            Console.WriteLine("Room where the microwave will be installed: K (kitchen) or W (work site):");
            Microwave.RoomTypeSet location;
            string letter = Console.ReadLine();


            if (letter == "W")
            {
                location = Microwave.RoomTypeSet.W;
            }
            else
            {
                location = Microwave.RoomTypeSet.K;
            }
            Console.WriteLine("Matching microwaves:");
            foreach (Appliance app in list)
            {
                if (app is Microwave && ((Microwave)app).RoomType == location)
                {
                    Console.WriteLine((Microwave)app);
                    Console.WriteLine();
                }
            }
        }

        // DisplayDishwasher
        public void DisplayDishwasher(List<Appliance> list)
        {
            Console.WriteLine("Enter the sound rating of the dishwasher: Qt (Quietest), Qr (Quieter), Qu(Quiet) or M (Moderate):");
            Dishwasher.SoundRatingType soundrating;
            string abbr = Console.ReadLine();
            switch (abbr)
            {
                case "Qt":
                    soundrating = Dishwasher.SoundRatingType.Qt;
                    break;
                case "Qr":
                    soundrating = Dishwasher.SoundRatingType.Qr;
                    break;
                case "Qu":
                    soundrating = Dishwasher.SoundRatingType.Qu;
                    break;
                case "M":
                    soundrating = Dishwasher.SoundRatingType.M;
                    break;
                default:
                    soundrating = Dishwasher.SoundRatingType.Default;
                    break;
            }
            Console.WriteLine("Matching dishwashers:");
            foreach (Appliance app in list)
            {
                if (app is Dishwasher && ((Dishwasher)app).SoundRating == soundrating)
                {
                    Console.WriteLine((Dishwasher)app);
                    Console.WriteLine();
                }
            }
        }


        //----- Option 4 : Random -----//
        public List<int> RandomList(List<Appliance> list)
        {
            // Get number of input
            Console.WriteLine("Enter number of appliances:");
            int numberOfApp = Convert.ToInt16(Console.ReadLine());

            // Create List nums: 0 - Count
            List<int> nums = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                nums.Add(i);
            }

            // Create List indexes: randomly select from nums, the number depends on input 
            Random random = new Random();
            List<int> indexes = new List<int>();
            int index;
            for (int i = 0; i < numberOfApp; i++)
            {
                index = random.Next(0, list.Count);
                indexes.Add(nums[index]);
                nums.RemoveAt(index);
            }
            return indexes;
        }

        //-----  Option 5 : Save -----//
        public void Save(List<Appliance> list)
        {
            string path = "..\\..\\Res\\appliances.txt";
            string info;
            List<string> infoList = new List<string>();

            foreach (Appliance app in list)
            {
                info = app.FormatForFile();
                infoList.Add(info);
            }
            File.AppendAllLines(path, infoList);
        }





        //----- Read file and Create Appliances -----//


        // ReadAppliances
        public List<Appliance> ReadAppliances()
        {
            List<Appliance> list = new List<Appliance>();
            string path = "..\\..\\Res\\appliances.txt";
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                string[] items = line.Split(';');
                CreateAppliance(items, list);
            }
            return list;
        }
        // CreateAppliance
        public void CreateAppliance(string[] items, List<Appliance> list)
        {
            char typeNum = items[0].ElementAt(0);
            switch (typeNum)
            {
                case '1':
                    list.Add(CreateRefrigerator(items));
                    break;
                case '2':
                    list.Add(CreateVacuum(items));
                    break;
                case '3':
                    list.Add(CreateMicrowave(items));
                    break;
                case '4':
                case '5':
                    list.Add(CreateDishwasher(items));
                    break;
                default:
                    Console.WriteLine("");
                    break;
            }
        }

        // CreateRefrigerator
        public Appliance CreateRefrigerator(string[] items)
        {
            Appliance app = new Refrigerator();
            app.ItemNumber = Convert.ToInt32(items[0]);
            app.Brand = items[1];
            app.Quantity = Convert.ToInt16(items[2]);
            app.Wattage = Convert.ToInt16(items[3]);
            app.Color = items[4];
            app.Price = Convert.ToDouble(items[5]);
            ((Refrigerator)app).Doors = Convert.ToInt16(items[6]);
            ((Refrigerator)app).Height = Convert.ToDouble(items[7]);
            ((Refrigerator)app).Width = Convert.ToDouble(items[8]);
            return app;
        }
        //CreateVacuum
        public Appliance CreateVacuum(string[] items)
        {
            Appliance app = new Vacuum();
            app.ItemNumber = Convert.ToInt32(items[0]);
            app.Brand = items[1];
            app.Quantity = Convert.ToInt16(items[2]);
            app.Wattage = Convert.ToInt16(items[3]);
            app.Color = items[4];
            app.Price = Convert.ToDouble(items[5]);
            ((Vacuum)app).Grade = items[6];
            ((Vacuum)app).BatteryVoltage = Convert.ToInt16(items[7]);

            return app;
        }
        //CreateMicrowave
        public Appliance CreateMicrowave(string[] items)
        {
            Appliance app = new Microwave();
            app.ItemNumber = Convert.ToInt32(items[0]);
            app.Brand = items[1];
            app.Quantity = Convert.ToInt16(items[2]);
            app.Wattage = Convert.ToInt16(items[3]);
            app.Color = items[4];
            app.Price = Convert.ToDouble(items[5]);
            ((Microwave)app).Capacity = Convert.ToDouble(items[6]);
            if (items[7] == "K")
            {
                ((Microwave)app).RoomType = Microwave.RoomTypeSet.K;
            }
            else
            {
                ((Microwave)app).RoomType = Microwave.RoomTypeSet.W;
            }

            return app;
        }
        //CreateDishwasher
        public Appliance CreateDishwasher(string[] items)
        {
            Appliance app = new Dishwasher();
            app.ItemNumber = Convert.ToInt32(items[0]);
            app.Brand = items[1];
            app.Quantity = Convert.ToInt16(items[2]);
            app.Wattage = Convert.ToInt16(items[3]);
            app.Color = items[4];
            app.Price = Convert.ToDouble(items[5]);
            ((Dishwasher)app).Feature = items[6];
            switch (items[7])
            {
                case "Qt":
                    ((Dishwasher)app).SoundRating = Dishwasher.SoundRatingType.Qt;
                    break;
                case "Qr":
                    ((Dishwasher)app).SoundRating = Dishwasher.SoundRatingType.Qr;
                    break;
                case "Qu":
                    ((Dishwasher)app).SoundRating = Dishwasher.SoundRatingType.Qu;
                    break;
                case "M":
                    ((Dishwasher)app).SoundRating = Dishwasher.SoundRatingType.M;
                    break;
            }
            return app;
        }




    }
}
