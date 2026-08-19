using System;
using Assignment5_OOP.classes;

namespace Assignment5_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Assigment4

            //    DeliveryCenter center = new DeliveryCenter("Main Delivery Center");

            //    DeliveryAddress address1 = new DeliveryAddress("Cairo", "Tahrir Street", 10);
            //    DeliveryAddress address2 = new DeliveryAddress("Alexandria", "Corniche Street", 25);
            //    DeliveryAddress address3 = new DeliveryAddress("Berlin", "Alexanderplatz", 5);


            //    StandardShipment standardShipment = new StandardShipment(
            //        "SH001", "Laptop", 2, 95m, address1);

            //    ExpressShipment expressShipment = new ExpressShipment(
            //        "SH002", "Documents", 4, 50m, address2, 30m);

            //    InternationalShipment internationalShipment = new InternationalShipment(
            //        "SH003", "Machine Parts", 12, 100m, address3, "Germany", 100m);


            //    center.AddShipment(standardShipment);
            //    center.AddShipment(expressShipment);
            //    center.AddShipment(internationalShipment);


            //    Console.WriteLine("==========================================");
            //    Console.WriteLine("Delivery Center");
            //    Console.WriteLine("==========================================");
            //    Console.WriteLine();

            //    center.PrintAllShipments();

            //    ITrackable[] trackableShipments =
            //    {
            //        standardShipment,
            //        expressShipment,
            //        internationalShipment
            //    };

            //    Console.WriteLine();
            //    Console.WriteLine("==========================================");
            //    Console.WriteLine();
            //    Console.WriteLine("Tracking Status");
            //    Console.WriteLine();

            //    for (int i = 0; i < trackableShipments.Length; i++)
            //    {
            //        if (i > 0)
            //        {
            //            Console.WriteLine();
            //        }
            //        Console.WriteLine(trackableShipments[i].GetTrackingStatus());
            //    }

            //    IInsurable[] insurableShipments =
            //    {
            //        standardShipment,
            //        expressShipment,
            //        internationalShipment
            //    };

            //    Console.WriteLine();
            //    Console.WriteLine("==========================================");
            //    Console.WriteLine();
            //    Console.WriteLine("Insurance");
            //    Console.WriteLine();

            //    for (int i = 0; i < insurableShipments.Length; i++)
            //    {
            //        if (i > 0)
            //        {
            //            Console.WriteLine();
            //        }

            //        string label = insurableShipments[i] switch
            //        {
            //            StandardShipment => "Standard Shipment",
            //            ExpressShipment => "Express Shipment",
            //            InternationalShipment => "International Shipment",
            //            _ => "Shipment"
            //        };

            //        Console.WriteLine($"{label} Insurance : {insurableShipments[i].CalculateInsurance():0.00} EGP");
            //    }

            //    Console.WriteLine();
            //    Console.WriteLine("==========================================");
            //    Console.WriteLine();
            //    Console.WriteLine("Interface Polymorphism Demonstrated Successfully.");

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
            // No, a static method cannot directly access instance members because
            // instance members belong to a specific object.

            // c) What is a static constructor, and when is it executed?
            // Answer:
            // A static constructor initializes static members of a class.
            // It is executed automatically once, before the class is first used,
            // and it cannot be called manually.

            // d) What is a static class? Can you create an object from a static class?
            // Answer:
            // A static class contains only static members.
            // No, you cannot create an object from a static class.


            // Q4 — Extension Methods

            // a) What is an Extension Method?
            // Answer:
            // An Extension Method allows you to add a new method to an existing type
            // without modifying the original class or creating a derived class.

            // b) What keyword must be used in the first parameter of an extension method?
            // Answer:
            // The keyword "this" must be used in the first parameter.

            // c) Where must an extension method be declared?
            // Answer:
            // It must be declared inside a static class.

            // d) Can an extension method access private members of the class it extends?
            // Answer:
            // No. An extension method cannot directly access private members
            // of the class it extends.


            // Q5 — Partial Classes and Partial Methods

            // a) What is a Partial Class?
            // Answer:
            // A Partial Class allows one class to be divided into multiple files.
            // All parts are combined by the compiler into one class.

            // b) Why would a developer split one class into multiple files?
            // Answer:
            // To organize large classes, separate responsibilities,
            // and make the code easier to maintain and understand.

            // c) What is a Partial Method?
            // Answer:
            // A Partial Method is a method that can be declared in one part
            // of a partial class and implemented in another part.

            // d) What happens if a declared partial method has no implementation?
            // Answer:
            // If a partial method has no implementation, the compiler removes
            // its declaration and all calls to it, so it has no effect at runtime.

            #endregion




        }
    }
}