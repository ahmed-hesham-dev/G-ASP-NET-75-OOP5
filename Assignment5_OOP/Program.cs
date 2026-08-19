using System;
using Assignment5_OOP.classes;

namespace Assignment5_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeliveryCenter center = new DeliveryCenter("Main Delivery Center");

            DeliveryAddress address1 = new DeliveryAddress("Cairo", "Tahrir Street", 10);
            DeliveryAddress address2 = new DeliveryAddress("Alexandria", "Corniche Street", 25);
            DeliveryAddress address3 = new DeliveryAddress("Berlin", "Alexanderplatz", 5);

            
            StandardShipment standardShipment = new StandardShipment(
                "SH001", "Laptop", 2, 95m, address1);

            ExpressShipment expressShipment = new ExpressShipment(
                "SH002", "Documents", 4, 50m, address2, 30m);

            InternationalShipment internationalShipment = new InternationalShipment(
                "SH003", "Machine Parts", 12, 100m, address3, "Germany", 100m);

            
            center.AddShipment(standardShipment);
            center.AddShipment(expressShipment);
            center.AddShipment(internationalShipment);

            
            Console.WriteLine("==========================================");
            Console.WriteLine("Delivery Center");
            Console.WriteLine("==========================================");
            Console.WriteLine();

            center.PrintAllShipments();

            ITrackable[] trackableShipments =
            {
                standardShipment,
                expressShipment,
                internationalShipment
            };

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine();
            Console.WriteLine("Tracking Status");
            Console.WriteLine();

            for (int i = 0; i < trackableShipments.Length; i++)
            {
                if (i > 0)
                {
                    Console.WriteLine();
                }
                Console.WriteLine(trackableShipments[i].GetTrackingStatus());
            }

            IInsurable[] insurableShipments =
            {
                standardShipment,
                expressShipment,
                internationalShipment
            };

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine();
            Console.WriteLine("Insurance");
            Console.WriteLine();

            for (int i = 0; i < insurableShipments.Length; i++)
            {
                if (i > 0)
                {
                    Console.WriteLine();
                }

                string label = insurableShipments[i] switch
                {
                    StandardShipment => "Standard Shipment",
                    ExpressShipment => "Express Shipment",
                    InternationalShipment => "International Shipment",
                    _ => "Shipment"
                };

                Console.WriteLine($"{label} Insurance : {insurableShipments[i].CalculateInsurance():0.00} EGP");
            }

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine();
            Console.WriteLine("Interface Polymorphism Demonstrated Successfully.");
        }
    }
}