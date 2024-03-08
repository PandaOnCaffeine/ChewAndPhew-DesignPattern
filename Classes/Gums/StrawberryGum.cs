using ChewAndPhew_DesignPattern.Abstract_Classes;

namespace ChewAndPhew_DesignPattern.Classes.Gums
{
    internal class StrawberryGum : Gum
    {
        public StrawberryGum() : base()
        {
            this.Name = "Strawberry Gum";
            this.AmountPerRefill = 8;
        }
    }
}
