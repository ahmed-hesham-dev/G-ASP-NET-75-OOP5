using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5_OOP.classes
{
    internal class InternationalShipment : Shipment, IInsurable, ITrackable
    {
        private String destinationCountry;
        private decimal customsFee;

        public InternationalShipment(string trackingCode,
            string description,
            double weight,
            decimal deliveryFee,
            DeliveryAddress destination,
            string destinationCountry,
            decimal customsFee) :
            base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }

        public string DestinationCountry
        {
            get
            {
                return destinationCountry;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    destinationCountry = value;
                }
            }
        }

        public decimal CustomsFee
        {
            get
            {
                return customsFee;
            }
            set
            {
                if (value >= 0)
                {
                    customsFee = value;
                }
            }
        }

        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (decimal)(Weight * 5) + CustomsFee;
            }
        }

        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine("GenerateCustomsReport");
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.12m;
        }

     
        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} has been Delivered.";
        }

        public void Track()
        {
            Console.WriteLine($"Tracking shipment {TrackingCode}...");
        }

       
        public override void PrintShipment()
        {
            Console.WriteLine("International Shipment");
            Console.WriteLine();
            Console.WriteLine($"{"Tracking Code",-22}: {TrackingCode}");
            Console.WriteLine($"{"Destination Country",-22}: {DestinationCountry}");
            Console.WriteLine($"{"Estimated Cost",-22}: {EstimatedCost} EGP");
        }
    }
}