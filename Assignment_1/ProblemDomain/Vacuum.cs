using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Vacuum : Appliance
    {
        enum BatteryVoltageType
        {
            low = 18,
            high = 24
        }
        private int batteryVoltage;
        private string grade;

        public int BatteryVoltage { get => batteryVoltage; set => batteryVoltage = value; }
        public string Grade { get => grade; set => grade = value; }

        public Vacuum()
        {
            
        }

        public Vacuum(string brand, string color, int itemNumber, float price, int quantity, float wattage, int batteryVoltage, string grade) : base(brand, color, itemNumber, price, quantity, wattage)
        {
            this.batteryVoltage = batteryVoltage;
            this.grade = grade;
        }

        public override string ToString()
        {
            return "ItemNumber: " + ItemNumber + "\nBrand: " + Brand +
                "\nQuantity: " + Quantity + "\nWattage: " + Wattage +
                "\nColor: " + Color + "\nPrice: " + Price +
                "\nGrade: " + Grade + "\nBatteryVoltage: " + (BatteryVoltageType)BatteryVoltage;
        }

        public override string FormatForFile()
        {
            return ItemNumber + ";" + Brand +
                ";" + Quantity + ";" + Wattage +
                ";" + Color + ";" + Price +
                ";" + Grade + ";" + (int)BatteryVoltage;
        }
    }




    
}
