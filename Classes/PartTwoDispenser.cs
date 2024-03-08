using ChewAndPhew_DesignPattern.Abstract_Classes;

namespace ChewAndPhew_DesignPattern.Classes
{
    internal class PartTwoDispenser : GumDispenser
    {
        private static PartTwoDispenser instance;
        public static PartTwoDispenser Instance
        {
            get // Only Get because it makes it so you cant make a new instanse of the class other places
            {
                if (instance == null) // If there's not a instance of the PartTwoDispenser
                {
                    // Make a instanse of PartTwoDispenser
                    instance = new PartTwoDispenser();
                }
                // Return instance
                return instance;
            }
        }
        // Private Constructor, so it can't be called other then in this class
        private PartTwoDispenser() { }
    }
}
