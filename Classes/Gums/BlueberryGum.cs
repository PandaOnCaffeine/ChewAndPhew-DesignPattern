using ChewAndPhew_DesignPattern.Abstract_Classes;

namespace ChewAndPhew_DesignPattern.Classes.Gums
{
    internal class BlueberryGum : Gum
    {
        public BlueberryGum() : base()
        {
            this.Name = "Blueberry Gum";
            this.AmountPerRefill = 14;
        }
    }
}
