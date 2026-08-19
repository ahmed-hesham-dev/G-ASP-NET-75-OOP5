using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5_OOP.classes
{
    internal class CompletedShipment: Shipment
    {
        public CompletedShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination) :
          base(trackingCode, description, weight, deliveryFee, destination)
        { }

        public override decimal EstimatedCost => throw new NotImplementedException();

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override void PrintShipment()
        {
            throw new NotImplementedException();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
