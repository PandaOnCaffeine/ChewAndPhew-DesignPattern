using ChewAndPhew_DesignPattern.Classes.Gums;
using System;
using System.Collections.Generic;
using System.Linq;

using Medallion;

namespace ChewAndPhew_DesignPattern.Abstract_Classes
{
    internal abstract class GumDispenser
    {
        List<Gum> inventory = new List<Gum>();

        List<Gum> GumTypes = new List<Gum>()
        {
            new BlueberryGum(),
            new BlackberryGum(),
            new TuttiFruttiGum(),
            new OrangeGum(),
            new StrawberryGum(),
            new AppleGum()
        };

        public virtual void Refill()
        {
            // Goes thru all types of gums and adds the right amount of them to the inventory of the dispenser
            foreach (Gum gum in GumTypes)
            {
                // Adds a object to the inventory list till the amount for that type of gum is hit. 
                for (int i = 0; i < gum.AmountPerRefill; i++)
                {
                    // Adds the gum to the inventory list
                    this.inventory.Add(gum);
                }
                Console.WriteLine($"Added {gum.AmountPerRefill} of {gum.Name}");
            }
        }

        public virtual void Shuffle()
        {
            // Uses NuGet Package called MedallionRandom, which add some extensions to for example List.
            // List.Shuffle(random); Shuffels the list using the "Fisher–Yates" shuffle
            var rand = new Random();
            inventory.Shuffle(rand);
        }

        // Return a string that shows the name of all the gums in the dispenser
        public virtual string GetInventory()
        {
            string inventoryList = "";
            foreach (Gum gum in inventory)
            {
                inventoryList += gum.Name + "\n";
            }
            return inventoryList;
        }

        // Returns the amount of gums left in the dispenser
        public virtual string GetAmountLeft()
        {
            return inventory.Count.ToString();
        }

        public virtual void DispenseGum()
        {
            if (inventory.Count > 0)
            {
                inventory.RemoveAt(0);
            }
        }
    }
}
