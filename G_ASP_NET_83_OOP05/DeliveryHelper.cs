using System;
using System.Collections.Generic;
using System.Text;

namespace G_ASP_NET_83_OOP05
{
    // A static class can contain only static members.
    // a collection of functionality that doesn't need an object
    public static class DeliveryHelper
    {
        public static void PrintShipmentDetails(Shipment shipment) {
            if (shipment != null)
            {
                Console.WriteLine(shipment.PrintShipment());
            }

        }
    }
}
