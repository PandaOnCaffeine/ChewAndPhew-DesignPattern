using ChewAndPhew_DesignPattern.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChewAndPhew_DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Use the instance of PartTwoDispenser and call the method GetAmountLeft to check how many gums are in the dispenser.
            Console.WriteLine($"Gums left: {PartTwoDispenser.Instance.GetAmountLeft()}\n");

            // Use the instance of PartTwoDispenser to call the refill method and refill the dispenser with gums.
            PartTwoDispenser.Instance.Refill();

            // Skip a line
            Console.WriteLine("");

            // Shuffle the refilled gums
            PartTwoDispenser.Instance.Shuffle();

            // Call GetAmountLeft method again and check that there's gum in the dispenser now
            Console.WriteLine($"Gums amount left: {PartTwoDispenser.Instance.GetAmountLeft()}\n");

            // Call GetInventory method to show the kind of gum that are in the dispenser.
            Console.WriteLine($"Inventory:\n\n{PartTwoDispenser.Instance.GetInventory()}\n");

            // Call DispenseGum Method that removes one gum from the dispenser.
            PartTwoDispenser.Instance.DispenseGum();

            // Call GetAmountLeft method again and check that there's gum in the dispenser now
            Console.WriteLine($"Gums amount left: {PartTwoDispenser.Instance.GetAmountLeft()}\n");

            // Call GetInventory method to show the kind of gum that are in the dispenser.
            Console.WriteLine($"Inventory:\n\n{PartTwoDispenser.Instance.GetInventory()}\n");

            Console.ReadLine(); // Stop Console from closing
        }
    }
}
