using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5_OOP.classes
{
    internal class ExpressShipment : Shipment, IInsurable, ITrackable
    {
        private decimal extraFee;
        public ExpressShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination, decimal extraFee) :
            base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }

        public decimal ExtraFee
        {
            get
            {
                return extraFee;
            }
            set
            {
                if (value >= 0)
                {
                    extraFee = value;
                }
            }
        }

        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (decimal)(Weight * 5) + ExtraFee;
            }
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.08m;
        }

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Out for Delivery.";
        }

        public void Track()
        {
            Console.WriteLine($"Tracking shipment {TrackingCode}...");
        }

        public override void PrintShipment()
        {
            Console.WriteLine("Express Shipment");
            Console.WriteLine();
            Console.WriteLine($"{"Tracking Code",-14}: {TrackingCode}");
            Console.WriteLine($"{"Extra Fee",-14}: {ExtraFee} EGP");
            Console.WriteLine($"{"Estimated Cost",-14}: {EstimatedCost} EGP");
        }
    }
}