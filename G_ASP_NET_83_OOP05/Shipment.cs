using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace G_ASP_NET_83_OOP05
{
    public abstract partial class Shipment
    {
        private string TrackingCode;
        private string Description;
        private decimal Weight;
        private decimal DeliveryFee;

        static int TotalShipmentsCreated;


        // Read-only from outside
        public string trackingCode
        {
            get => TrackingCode;
            private set
            {
                if (!string.IsNullOrEmpty(value))
                    TrackingCode = value;

            }
        }


        public string description
        {
            get => Description;
            set
            {
                if (!string.IsNullOrEmpty(value))
                    Description = value;
            }
        }

        public decimal weight
        {
            get => Weight;
            set
            {
                if (value > 0)
                    Weight = value;
            }
        }

        // public getter and private setter. 
        public decimal deliveryFee
        {
            get => DeliveryFee;
            private set
            {
                if (value > 0)
                    DeliveryFee = value;
            }
        }






        public abstract decimal EstimatedCost { get; }

        //get => (Weight * 5) + DeliveryFee;


        public DeliveryAddress Destination { get; set; }

        static Shipment()
        {
            Console.WriteLine("Shipment System Initialized ");
            TotalShipmentsCreated = 0;
        }
        public Shipment(string TrackingCode) : this(TrackingCode, "Unknown", 1, 50, new DeliveryAddress("Unknown", "Unknown", 1), "unknown")
        {

        }

        public Shipment(string TrackingCode, string Description, decimal Weight, decimal DeliveryFee, DeliveryAddress Destination, string Status)
        {
            this.TrackingCode = string.IsNullOrWhiteSpace(TrackingCode) ? "Unknown" : TrackingCode;
            this.Description = string.IsNullOrWhiteSpace(Description) ? "Unknown" : Description;
            this.Status = string.IsNullOrWhiteSpace(Status) ? "Unknown" : Status;
            this.Weight = Weight > 0 ? Weight : 1;
            this.DeliveryFee = DeliveryFee > 0 ? DeliveryFee : 50;
            this.Destination = Destination;
            TotalShipmentsCreated++;
        }

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
                DeliveryFee = newFee;
        }


        public void UpdateWeight(decimal weight)
        {
            if (Weight > 0)
                Weight = weight;

        }
        public void UpdateWeight(decimal weight, decimal extraWeight)
        {
            if (Weight > 0 && extraWeight > 0)
                Weight = weight + extraWeight;

        }


        public static int GetTotalShipmentsCreated()
        {
            return TotalShipmentsCreated;

        }


        public Shipment CopyShipment()
        {

            return this.DeepCopy();
        }


        public Shipment ShallowCopy()
        {

            return (Shipment)this.MemberwiseClone();

        }



        public Shipment DeepCopy()
        {
            Shipment copiedShipment =
               (Shipment)this.MemberwiseClone();
            copiedShipment.TrackingCode = new string(this.TrackingCode);
            copiedShipment.TrackingCode = new string(this.Description);

            copiedShipment.Destination =
                    new DeliveryAddress(
                        this.Destination.city,
                        this.Destination.street,
                        this.Destination.buildingNumber);
                return copiedShipment;
        }

        public partial void OnTrackingStatusChanged(string newStatus);
        public abstract string PrintShipment();


            //return $"""
            //    tracking code: {trackingCode}
            //    description: {description}
            //    weight: {weight} kg
            //    delivery fee: ${deliveryFee} egp
            //    estimated cost: ${EstimatedCost}
            //    """;

        




    }
}
