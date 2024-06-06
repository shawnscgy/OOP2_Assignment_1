using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public interface IModernAppliances
    {
        //Display Menu
        string DisplayMenu();



                     //----- Option 1 : Checkout -----//

        // Checkout
        void Checkout(Appliance app);

        // Find
        Appliance Find(List<Appliance> list);


                      //----- Option 2 : Find -----//

        void SearchByBrand(List<Appliance> list);

                      //-----  Option 3 : Display  ----- //

        // Display by Type
        void DisplayAppliancesByType(List<Appliance> list);

        // DisplayRefrigerator
        void DisplayRefrigerator(List<Appliance> list);


        //DisplayVacuum
        void DisplayVacuum(List<Appliance> list);

        // DisplayMicrowave
        void DisplayMicrowave(List<Appliance> list);


        // DisplayDishwasher
        void DisplayDishwasher(List<Appliance> list);




                         //----- Option 4 : Random -----//

        List<int> RandomList(List<Appliance> list);


                         //-----  Option 5 : Save -----//
        void Save(List<Appliance> list);


                   //----- Read file and Create Appliances -----//


        // ReadAppliances
        List<Appliance> ReadAppliances();

        // CreateAppliance
        void CreateAppliance(string[] items, List<Appliance> list);

        // CreateRefrigerator
        Appliance CreateRefrigerator(string[] items);

        //CreateVacuum
        Appliance CreateVacuum(string[] items);

        //CreateMicrowave
        Appliance CreateMicrowave(string[] items);

        //CreateDishwasher
        Appliance CreateDishwasher(string[] items);

    }
}

