using System;

namespace Assignment5_OOP.classes
{
    public static class DeliveryUtilities
    {
        public static void PrintSeparator()
        {
            Console.WriteLine("==========================================");
        }

        public static void PrintSystemTitle()
        {
            PrintSeparator();
            Console.WriteLine("              Delivery Center");
            PrintSeparator();
        }
    }
}