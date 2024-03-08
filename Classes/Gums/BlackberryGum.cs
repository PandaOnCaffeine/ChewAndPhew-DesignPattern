using ChewAndPhew_DesignPattern.Abstract_Classes;

namespace ChewAndPhew_DesignPattern.Classes.Gums
{
    internal class BlackberryGum : Gum
    {
        public BlackberryGum() : base()
        {
            this.Name = "Blackberry Gum";
            this.AmountPerRefill = 7;
        }
    }
}
