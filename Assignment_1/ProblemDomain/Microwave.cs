using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Microwave : Appliance
    {
        public enum RoomTypeSet
        {
            K,
            W
        }
        private double capacity;
        private RoomTypeSet roomType;

        public double Capacity { get => capacity; set => capacity = value; }
        public RoomTypeSet RoomType { get => roomType; set => roomType = value; }

        public Microwave()
        {

        }

        public Microwave(string brand, string color, int itemNumber, float price, int quantity, float wattage, double capacity, RoomTypeSet roomType) : base(brand, color, itemNumber, price, quantity, wattage)
        {
            this.capacity = capacity;
            this.RoomType = roomType;
        }

        public override string ToString()
        {
            string room;
            if (RoomType == RoomTypeSet.W)
            {
                room = "Work Site";
            }
            else
            {
                room = "Kechin";
            }
            return "ItemNumber: " + ItemNumber + "\nBrand: " + Brand +
                "\nQuantity: " + Quantity + "\nWattage: " + Wattage +
                "\nColor: " + Color + "\nPrice: " + Price +
                "\nCapacity: " + Capacity + "\nRoom Type: " + room;
        }

        public override string FormatForFile()
        {
            string room;
            if (RoomType == RoomTypeSet.W)
            {
                room = "W";
            }
            else
            {
                room = "K";
            }
            return ItemNumber + ";" + Brand +
                ";" + Quantity + ";" + Wattage +
                ";" + Color + ";" + Price +
                ";" + Capacity + ";" + room;
        }
    }
}
