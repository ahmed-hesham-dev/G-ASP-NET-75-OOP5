using System;

namespace Assignment5_OOP.classes
{
    public partial class Shipment
    {
        private string trackingStatus = "In Transit";

        #region Partial Method Declaration

        partial void OnTrackingStatusChanged(string newStatus);

        #endregion


        #region Tracking Methods

        public string GetTrackingStatus()
        {
            return trackingStatus;
        }

        public void UpdateTrackingStatus(string newStatus)
        {
            if (!string.IsNullOrWhiteSpace(newStatus))
            {
                trackingStatus = newStatus;

                OnTrackingStatusChanged(newStatus);
            }
        }

        #endregion
    }
}