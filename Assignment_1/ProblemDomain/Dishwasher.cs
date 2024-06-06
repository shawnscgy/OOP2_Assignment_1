using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Dishwasher : Appliance
    {

        public enum SoundRatingType
        {
            Qt,
            Qr,
            Qu,
            M,
            Default
        }
        private string feature;
        private SoundRatingType soundRating;

        public string Feature { get => feature; set => feature = value; }
        public SoundRatingType SoundRating { get => soundRating; set => soundRating = value; }

        public Dishwasher()
        {
        }

        public Dishwasher(string brand, string color, int itemNumber, float price, int quantity, float wattage, string feature, SoundRatingType soundRating) : base(brand, color, itemNumber, price, quantity, wattage)
        {
            this.feature = feature;
            this.soundRating = soundRating;
        }

        public override string ToString()
        {
            string sound;
            switch (SoundRating)
            {
                case SoundRatingType.Qt:
                    sound = "Qiutest";
                    break;
                case SoundRatingType.Qr:
                    sound = "Qiuter";
                    break;
                case SoundRatingType.Qu:
                    sound = "Qiuet";
                    break;
                case SoundRatingType.M:
                    sound = "Moderate";
                    break;
                default:
                    sound = "Unknown"; 
                    break;
            }
            return "ItemNumber: " + ItemNumber + "\nBrand: " + Brand +
                "\nQuantity: " + Quantity + "\nWattage: " + Wattage +
                "\nColor: " + Color + "\nPrice: " + Price +
                "\nFeature: " + Feature + "\nSoundRating: " + sound;
        }

        public override string FormatForFile()
        {
            return ItemNumber + ";" + Brand +
               ";" + Quantity + ";" + Wattage +
               ";" + Color + ";" + Price +
               ";" + Feature + ";" + SoundRating;
        }
    }
}
