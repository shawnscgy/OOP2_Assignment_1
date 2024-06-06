using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public abstract class Appliance : Object
    {
        private string brand;
        private string color;
        private long itemNumber;
        private double price;
        private int quantity;
        private double wattage;

        public string Brand { get => brand; set => brand = value; }
        public string Color { get => color; set => color = value; }
        public long ItemNumber { get => itemNumber; set => itemNumber = value; }
        public double Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double Wattage { get => wattage; set => wattage = value; }

        public Appliance()
        {
        }

        public Appliance(string brand, string color, long itemNumber, double price, int quantity, double wattage)
        {
            this.brand = brand;
            this.color = color;
            this.itemNumber = itemNumber;
            this.price = price;
            this.quantity = quantity;
            this.wattage = wattage;
        }


        public override string ToString()
        {
            return base.ToString();
        }

        public void Checkout()
        {

        }

        public abstract string FormatForFile();

        public static void Checkout(Appliance app)
        {

        }
    }
}
