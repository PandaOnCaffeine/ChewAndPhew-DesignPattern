using ChewAndPhew_DesignPattern.Abstract_Classes;

namespace ChewAndPhew_DesignPattern.Classes.Gums
{
    internal class OrangeGum : Gum
    {
        public OrangeGum() : base()
        {
            this.Name = "Orange Gum";
            this.AmountPerRefill = 10;
        }
    }
}
