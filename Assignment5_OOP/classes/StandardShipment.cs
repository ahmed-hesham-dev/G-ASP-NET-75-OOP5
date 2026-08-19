using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5_OOP.classes
{
    internal class StandardShipment : Shipment, ITrackable, IInsurable
    {
        public StandardShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination) :
        base(trackingCode, description, weight, deliveryFee, destination)
        { }

        public override decimal EstimatedCost => DeliveryFee;

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.05m;
        }

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Ready.";
        }

        public void Track()
        {
            Console.WriteLine($"Tracking shipment {TrackingCode}...");
        }

        public override void PrintShipment()
        {
            Console.WriteLine("Standard Shipment");
            Console.WriteLine();
            Console.WriteLine($"{"Tracking Code",-14}: {TrackingCode}");
            Console.WriteLine($"{"Description",-14}: {Description}");
            Console.WriteLine($"{"Estimated Cost",-14}: {EstimatedCost} EGP");
        }
    }
}