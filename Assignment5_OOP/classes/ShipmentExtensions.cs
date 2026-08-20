using System;

namespace Assignment5_OOP.classes
{
    public static class ShipmentExtensions
    {
        public static string GetSummary(this Shipment shipment)
        {
            return $"{shipment.TrackingCode} | " +
                   $"{shipment.GetType().Name.Replace("Shipment", "")} | " +
                   $"{shipment.Weight} KG | " +
                   $"{shipment.GetTrackingStatus()}";
        }

        public static bool IsDelivered(this Shipment shipment)
        {
            return shipment.GetTrackingStatus() == "Delivered";
        }
    }
}