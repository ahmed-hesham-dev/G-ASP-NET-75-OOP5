using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5_OOP.classes
{
    internal class DeliveryReport
    {
        public void PrintShipment(ITrackable shipment)
        {
            shipment.Track();
        }

        public void PrintInsurance(IInsurable shipment)
        {
            Console.WriteLine($"Insurance Cost: {shipment.CalculateInsurance()}");
        }
    }
}
