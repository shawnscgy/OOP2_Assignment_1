using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Refrigerator : Appliance
    {
        enum DoorNum
        {
            Double = 2,
            Three = 3,
            Four = 4
        }
        private int doors;
        private double height;
        private double width;

        public int Doors { get => doors; set => doors = value; }
        public double Height { get => height; set => height = value; }
        public double Width { get => width; set => width = value; }

        public Refrigerator()
        {

        }

        public Refrigerator(string brand, string color, int itemNumber, float price, int quantity, float wattage, int doors, double height, double width) : base(brand, color, itemNumber, price, quantity, wattage)
        {
            this.doors = doors;
            this.height = height;
            this.width = width;
        }

        public override string ToString()
        {
            return "ItemNumber: " + ItemNumber + "\nBrand: " + Brand +
                "\nQuantity: " + Quantity + "\nWattage: " + Wattage +
                "\nColor: " + Color + "\nPrice: " + Price +
                "\nNumber of Doors: " + (DoorNum)Doors + " Doors\nHeight: " + Height + "\nWidth: " + Width;
        }

        public override string FormatForFile()
        {
            return ItemNumber + ";" + Brand +
               ";" + Quantity + ";" + Wattage +
               ";" + Color + ";" + Price +
               ";" + (int)Doors + ";" + Height + ";" + Width;
        }
    }
}