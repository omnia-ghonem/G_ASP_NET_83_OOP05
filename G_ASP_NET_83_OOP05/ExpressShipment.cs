using System;
using System.Collections.Generic;
using System.Text;

namespace G_ASP_NET_83_OOP05
{
    public class ExpressShipment : Shipment, ITrackable, IInsurable
    {
        private decimal ExtraFee;


        public decimal extraFee
        {
            get => ExtraFee;
            set
            {
                if (value >= 0)
                    ExtraFee = value;
            }
        }



        public override decimal EstimatedCost
        {
            get => (weight * 5) + deliveryFee + ExtraFee;
        }

        public ExpressShipment(string TrackingCode, string Description, decimal Weight, decimal DeliveryFee, DeliveryAddress Destination, decimal extraFee, string Status) : base(TrackingCode, Description, Weight, DeliveryFee, Destination, Status)
        {
            ExtraFee = extraFee > 0 ? extraFee : 50;
        }

        #region Abstract Method
        // Shipment
        public override string PrintShipment()
        {

            return $"""  
                    Tracking Code: {trackingCode}
                    Extra Fee: {ExtraFee}
                    Estimated Cost: ${EstimatedCost}
                    ----------------------------------------
                    """;

        }



        // ITrackable

        public string GetTrackingStatus()
        {
            return $"Shipment {trackingCode} is {status}";
        }
        #endregion


        // IInsurable
        public decimal CalculateInsurance()
        {
            return (decimal)0.08 * EstimatedCost;
        }



    }

}
