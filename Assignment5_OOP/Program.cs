using System;
using Assignment5_OOP.classes;

namespace Assignment5_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Assignment 04

            // DeliveryCenter center = new DeliveryCenter("Main Delivery Center");

            // DeliveryAddress address1 = new DeliveryAddress("Cairo", "Tahrir Street", 10);
            // DeliveryAddress address2 = new DeliveryAddress("Alexandria", "Corniche Street", 25);
            // DeliveryAddress address3 = new DeliveryAddress("Berlin", "Alexanderplatz", 5);

            // StandardShipment standardShipment = new StandardShipment(
            //     "SH001", "Laptop", 2, 95m, address1);

            // ExpressShipment expressShipment = new ExpressShipment(
            //     "SH002", "Documents", 4, 50m, address2, 30m);

            // InternationalShipment internationalShipment = new InternationalShipment(
            //     "SH003", "Machine Parts", 12, 100m, address3, "Germany", 100m);

            // center.AddShipment(standardShipment);
            // center.AddShipment(expressShipment);
            // center.AddShipment(internationalShipment);

            // center.PrintAllShipments();

            // ITrackable[] trackableShipments =
            // {
            //     standardShipment,
            //     expressShipment,
            //     internationalShipment
            // };

            // IInsurable[] insurableShipments =
            // {
            //     standardShipment,
            //     expressShipment,
            //     internationalShipment
            // };

            #endregion


            #region Part 01 — Theoretical Questions

            // Q1 — Object Copying

            // a) What happens when you assign one object variable to another object variable?
            // Answer:
            // Both variables refer to the same object in memory.

            // b) Does assigning one object to another create a new object? Explain.
            // Answer:
            // No. Assigning one object variable to another does not create a new object.
            // It only copies the reference to the existing object.

            // c) What is the difference between copying an object and copying its reference?
            // Answer:
            // Copying the reference means both variables point to the same object.
            // Copying an object means creating a new object with the same data,
            // so the original and the copy are separate objects.


            // Q2 — Shallow Copy vs Deep Copy

            // a) What is a Shallow Copy?
            // Answer:
            // A Shallow Copy creates a new object, but reference-type members
            // still refer to the same objects as the original.

            // b) What is a Deep Copy?
            // Answer:
            // A Deep Copy creates a new object and also creates new objects
            // for its reference-type members.

            // c) What happens to reference-type members when a Shallow Copy is created?
            // Answer:
            // The reference-type members are copied as references,
            // so the original and copied objects share the same referenced objects.

            // d) What happens to reference-type members when a Deep Copy is created?
            // Answer:
            // New copies of the reference-type members are created,
            // so the original and copied objects do not share those objects.

            // e) Give one situation where Deep Copy would be safer than Shallow Copy.
            // Answer:
            // Deep Copy is safer when modifying the copied object must not affect
            // the original object, such as copying a Shipment with a DeliveryAddress.


            // Q3 — Static Members

            // a) What is a static field, and how is it different from an instance field?
            // Answer:
            // A static field belongs to the class itself and is shared by all objects.
            // An instance field belongs to a specific object, so each object has its own value.

            // b) What is a static method? Can a static method directly access instance members?
            // Answer:
            // A static method belongs to the class and can be called without creating an object.
            // No, a static method cannot directly access instance members.

            // c) What is a static constructor, and when is it executed?
            // Answer:
            // A static constructor initializes static members of a class.
            // It is executed automatically once before the class is first used.

            // d) What is a static class? Can you create an object from a static class?
            // Answer:
            // A static class contains only static members.
            // No, you cannot create an object from a static class.


            // Q4 — Extension Methods

            // a) What is an Extension Method?
            // Answer:
            // An Extension Method allows you to add a new method to an existing type
            // without modifying the original class.

            // b) What keyword must be used in the first parameter?
            // Answer:
            // The keyword "this".

            // c) Where must an extension method be declared?
            // Answer:
            // Inside a static class.

            // d) Can an extension method access private members?
            // Answer:
            // No.


            // Q5 — Partial Classes and Partial Methods

            // a) What is a Partial Class?
            // Answer:
            // A Partial Class allows one class to be divided into multiple files.

            // b) Why split one class into multiple files?
            // Answer:
            // To organize responsibilities and make the code easier to maintain.

            // c) What is a Partial Method?
            // Answer:
            // A Partial Method can be declared in one part of a partial class
            // and implemented in another part.

            // d) What happens if a partial method has no implementation?
            // Answer:
            // The compiler removes the declaration and calls to it.

            #endregion


            #region Create Shipments

            DeliveryUtilities.PrintSystemTitle();

            Console.WriteLine("Creating Shipments...");
            DeliveryUtilities.PrintSeparator();

            DeliveryAddress address1 =
                new DeliveryAddress("Cairo", "Tahrir Street", 10);

            DeliveryAddress address2 =
                new DeliveryAddress("Cairo", "Nasr City", 20);

            DeliveryAddress address3 =
                new DeliveryAddress("Cairo", "Heliopolis", 30);


            StandardShipment standardShipment =
                new StandardShipment(
                    "SH001",
                    "Laptop",
                    3,
                    95m,
                    address1);


            ExpressShipment expressShipment =
                new ExpressShipment(
                    "SH002",
                    "Documents",
                    2,
                    50m,
                    address2,
                    30m);


            InternationalShipment internationalShipment =
                new InternationalShipment(
                    "SH003",
                    "Machine Parts",
                    8,
                    100m,
                    address3,
                    "Germany",
                    100m);


            Console.WriteLine("Standard Shipment Created");
            Console.WriteLine("Express Shipment Created");
            Console.WriteLine("International Shipment Created");

            Console.WriteLine(
                $"Total Shipments Created : {Shipment.GetTotalShipmentsCreated()}");

            #endregion


            #region Object Copying

            DeliveryUtilities.PrintSeparator();

            Console.WriteLine("Object Copying");
            DeliveryUtilities.PrintSeparator();

            Shipment shipment1 = standardShipment;

            Shipment shipment2 = shipment1;

            Console.WriteLine(
                $"Original Shipment : {shipment1.TrackingCode}");

            Console.WriteLine(
                $"Assigned Shipment : {shipment2.TrackingCode}");

            Console.WriteLine(
                $"Same Object : {shipment1 == shipment2}");


            #region Shallow Copy

            DeliveryUtilities.PrintSeparator();

            Console.WriteLine("Shallow Copy");
            DeliveryUtilities.PrintSeparator();

            Shipment shallowCopy = shipment1.ShallowCopy();

            Console.WriteLine(
                $"Original Shipment Address : {shipment1.Destination.City}");

            Console.WriteLine(
                $"Copied Shipment Address : {shallowCopy.Destination.City}");

            Console.WriteLine("Changing copied shipment address...");

            shallowCopy.Destination.City = "Giza";

            Console.WriteLine(
                $"Original Shipment Address : {shipment1.Destination.City}");

            Console.WriteLine(
                $"Copied Shipment Address : {shallowCopy.Destination.City}");

            Console.WriteLine(
                $"Same DeliveryAddress Object : " +
                $"{shipment1.Destination == shallowCopy.Destination}");

            #endregion


            #region Deep Copy

            DeliveryUtilities.PrintSeparator();

            Console.WriteLine("Deep Copy");
            DeliveryUtilities.PrintSeparator();

            // Reset original address
            shipment1.Destination.City = "Cairo";

            Shipment deepCopy = shipment1.DeepCopy();

            Console.WriteLine(
                $"Original Shipment Address : {shipment1.Destination.City}");

            Console.WriteLine(
                $"Copied Shipment Address : {deepCopy.Destination.City}");

            Console.WriteLine("Changing copied shipment address...");

            deepCopy.Destination.City = "Giza";

            Console.WriteLine(
                $"Original Shipment Address : {shipment1.Destination.City}");

            Console.WriteLine(
                $"Copied Shipment Address : {deepCopy.Destination.City}");

            Console.WriteLine(
                $"Same DeliveryAddress Object : " +
                $"{shipment1.Destination == deepCopy.Destination}");

            #endregion

            #endregion


            #region Extension Methods

            DeliveryUtilities.PrintSeparator();

            Console.WriteLine("Extension Methods");
            DeliveryUtilities.PrintSeparator();

            standardShipment.UpdateTrackingStatus("In Transit");
            expressShipment.UpdateTrackingStatus("Out For Delivery");
            internationalShipment.UpdateTrackingStatus("Delivered");

            Console.WriteLine(standardShipment.GetSummary());
            Console.WriteLine(expressShipment.GetSummary());
            Console.WriteLine(internationalShipment.GetSummary());

            Console.WriteLine(
                $"SH001 Is Delivered : {standardShipment.IsDelivered()}");

            Console.WriteLine(
                $"SH003 Is Delivered : {internationalShipment.IsDelivered()}");

            #endregion


            #region Tracking Status

            DeliveryUtilities.PrintSeparator();

            Console.WriteLine("Tracking Status");
            DeliveryUtilities.PrintSeparator();

            standardShipment.UpdateTrackingStatus("Out For Delivery");

            #endregion


            #region Static Utilities

            DeliveryUtilities.PrintSeparator();

            Console.WriteLine("Static Utilities");
            DeliveryUtilities.PrintSeparator();

            DeliveryUtilities.PrintSeparator();

            Console.WriteLine("Delivery Center");

            DeliveryUtilities.PrintSeparator();

            Console.WriteLine(
                $"Total Shipments Created : {Shipment.GetTotalShipmentsCreated()}");

            #endregion


            #region Partial Method

            DeliveryUtilities.PrintSeparator();

            Console.WriteLine("Partial Method");
            DeliveryUtilities.PrintSeparator();

            internationalShipment.UpdateTrackingStatus("Delivered");

            #endregion


            #region Assignment Completed

            DeliveryUtilities.PrintSeparator();

            Console.WriteLine("Assignment Completed");

            DeliveryUtilities.PrintSeparator();

            #endregion
        }
    }
}