using System;
using System.Collections.Generic;
using System.Text;

namespace G_ASP_NET_83_OOP05
{
    public class StandardShipment : Shipment, ITrackable, IInsurable
    {
        public StandardShipment(string TrackingCode, string Description, decimal Weight, decimal DeliveryFee, DeliveryAddress Destination, string Status) : base(TrackingCode, Description, Weight, DeliveryFee, Destination, Status)
        {
        }

        // Abstract Property

        public override decimal EstimatedCost
        {

            get => (weight * 5) + deliveryFee;
        }

        #region Abstract Method
        // Shipment
        public override string PrintShipment()
        {
            return $"""
                    Tracking Code: {trackingCode}
                    Description: {description}
                    Estimated Cost: ${EstimatedCost}
                    ----------------------------------------
                    """;
        }

        // ITrackable

        public string GetTrackingStatus()
        {
            return $"Shipment {trackingCode} is {status}";
        }

        // IInsurable
        public decimal CalculateInsurance()
        {
            return (decimal)0.05 * EstimatedCost;
        }


        #endregion
    }

}
