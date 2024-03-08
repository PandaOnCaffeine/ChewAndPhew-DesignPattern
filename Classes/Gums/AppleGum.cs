using ChewAndPhew_DesignPattern.Abstract_Classes;

namespace ChewAndPhew_DesignPattern.Classes.Gums
{
    internal class AppleGum : Gum
    {
        public AppleGum() : base()
        {
            this.Name = "Apple Gum";
            this.AmountPerRefill = 5;
        }
    }
}
