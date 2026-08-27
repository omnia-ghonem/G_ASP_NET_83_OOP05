using System;
using System.Collections.Generic;
using System.Text;

namespace G_ASP_NET_83_OOP05
{

    // Extension Methods
    public static class ShipmentExtensions
    {
        public static string GetSummary(this Shipment shipment)
        {
            if (shipment == null)
                return "Shipment is null";

            string shipmentType =
                shipment.GetType().Name
                .Replace("Shipment", "");

            return $"{shipment.trackingCode} | " +
                   $"{shipmentType} | " +
                   $"{shipment.weight} KG | " +
                   $"{shipment.status}";
        }

        public static bool IsDelivered(this Shipment shipment)
        {
            if (shipment == null)
                return false;

            return Equals("Delivered".ToLower(), shipment.status.ToLower());
        }
    }
}
