using System;
using System.Collections.Generic;
using System.Text;

namespace G_ASP_NET_83_OOP05
{
    public class InternationalShipment : Shipment, ITrackable, IInsurable
    {
        private string DestinationCountry;
        private decimal CustomsFee;


        public string destinationCountry
        {
            get { return DestinationCountry; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    DestinationCountry = value;


            }
        }

        public decimal customsFee
        {
            get { return CustomsFee; }
            set
            {
                if (value >= 0)
                    CustomsFee = value;


            }
        }

        public override decimal EstimatedCost
        {
            get => (weight * 5) + deliveryFee + CustomsFee;
        }
        public InternationalShipment(string TrackingCode, string Description, decimal Weight, decimal DeliveryFee, DeliveryAddress Destination, string destinationCountry, decimal customsFee, string Status) : base(TrackingCode, Description, Weight, DeliveryFee, Destination, Status)
        {
            DestinationCountry = string.IsNullOrEmpty(destinationCountry) ? "Unknown" : destinationCountry;
            CustomsFee = customsFee > 0 ? customsFee : 50;
        }

        public virtual string GenerateCustomsReport() {
            return $"""
                Customer Report
                Tracking Code: {trackingCode}
                Destination Country: {DestinationCountry}
                Customs Fee: {CustomsFee} EGP
                """;
        }


        #region Abstract Method
        // Shipment
        public override string PrintShipment()
        {
            return $"""
                    Tracking Code: {trackingCode}
                    Destination Country: {DestinationCountry}
                    Estimated Cost: ${EstimatedCost}
         
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
            return (decimal)0.12 * EstimatedCost;
        }
        #endregion
    }

}
