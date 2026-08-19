using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5_OOP.classes
{
    public abstract class Shipment
    {
        private string description;
        private double weight;
        private decimal deliveryFee;

        #region property

        public DeliveryAddress Destination { get; set; }

        public string TrackingCode { get; init; }

        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    description = value;
                }
            }
        }

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
            }
        }

        public decimal DeliveryFee
        {
            get { return deliveryFee; }
            private set
            {
                if (value > 0)
                {
                    deliveryFee = value;
                }
            }
        }

        public abstract decimal EstimatedCost { get; }

        #endregion


        #region Static Members

        public static int TotalShipmentsCreated;

        static Shipment()
        {
            TotalShipmentsCreated = 0;
            Console.WriteLine("Shipment System Initialized");
        }

        public static int GetTotalShipmentsCreated()
        {
            return TotalShipmentsCreated;
        }

        #endregion


        #region Constructor 1&2

        // Constructor 1
        public Shipment(string trackingCode)
        {
            TotalShipmentsCreated++;

            TrackingCode = !string.IsNullOrWhiteSpace(trackingCode)
                ? trackingCode
                : "Unknown";

            description = "Unknown";
            weight = 1;
            deliveryFee = 50;

            Destination = new DeliveryAddress(
                "Unknown",
                "Unknown",
                0
            );
        }


        // Constructor 2
        public Shipment(
            string trackingCode,
            string description,
            double weight,
            decimal deliveryFee,
            DeliveryAddress destination)
        {
            TotalShipmentsCreated++;

            TrackingCode = !string.IsNullOrWhiteSpace(trackingCode)
                ? trackingCode
                : "Unknown";

            this.description = "Unknown";
            this.weight = 1;
            this.deliveryFee = 50;

            Destination = destination;

            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
        }

        #endregion


        #region Practical

        public double UpdateWeight(double newWeight)
        {
            if (newWeight > 0)
            {
                Weight = newWeight;
            }

            return Weight;
        }

        public double UpdateWeight(double newWeight, double extraPakeg)
        {
            if (newWeight > 0)
            {
                Weight = newWeight + extraPakeg;
            }

            return Weight;
        }

        #endregion


        #region Object Copying

        public Shipment CopyShipment()
        {
            return (Shipment)this.MemberwiseClone();
        }


        public Shipment ShallowCopy()
        {
            return (Shipment)this.MemberwiseClone();
        }


        public Shipment DeepCopy()
        {
            Shipment copy = (Shipment)this.MemberwiseClone();

            copy.Destination = new DeliveryAddress(
                this.Destination.City,
                this.Destination.Street,
                this.Destination.BuildingNumber
            );

            return copy;
        }

        #endregion


        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = newFee;
            }
        }


        public abstract void PrintShipment();
    }
}