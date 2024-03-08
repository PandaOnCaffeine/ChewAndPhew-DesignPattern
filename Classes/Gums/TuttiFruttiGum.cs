using ChewAndPhew_DesignPattern.Abstract_Classes;

namespace ChewAndPhew_DesignPattern.Classes.Gums
{
    internal class TuttiFruttiGum : Gum
    {
        public TuttiFruttiGum() : base()
        {
            this.Name = "Tutti Frutti Gum";
            this.AmountPerRefill = 11;
        }
    }
}
