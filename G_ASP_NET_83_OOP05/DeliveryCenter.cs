using System;
using System.Collections.Generic;
using System.Text;

namespace G_ASP_NET_83_OOP05
{
    public class DeliveryCenter
    {
        private string CenterName;
        private Shipment?[] shipments;
        private int shipmentCount;



        public Driver driver{ get; set; }

        public DeliveryCenter(string centerName)
        {
            CenterName = centerName;
            shipments = new Shipment[20];
        }

        // Integer indexer
        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < shipments.Length)
                {
                    return shipments[index];
                }

                return default;
            }

            set
            {
                if (index >= 0 && index < shipments.Length)
                {
                    shipments[index] = value;
                }
            }
        }

        // String indexer
        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i] != null &&  shipments[i].trackingCode == trackingCode)
                    {
                        return shipments[i];
                    }
                }

                return default;
            }
        }

        // AddShipment method
        public bool AddShipment(Shipment shipment)
        {

            if (shipmentCount >= shipments.Length)
            {
                Console.WriteLine("Delivery center is full.");
                return false;
            }

            shipments[shipmentCount] = shipment;
            shipmentCount++;
            Console.WriteLine($"{shipment.GetType().Name} is created");
            return true;


        }



        public bool RemoveShipment(string trackingCode)
        {

            int index = Search.BinarySearch(trackingCode, shipments, shipmentCount);

            if (index == -1)
            {
                return false;
            }

            // Shift elements to the left
            for (int i = index; i < shipmentCount - 1; i++)
            {
                shipments[i] = shipments[i + 1];
            }

            shipments[shipmentCount - 1] = null;

            shipmentCount--;

            return true;
        }






        public void PrintAllShipments()
        {
            for (int i = 0; i < shipmentCount; i++)
            {
                if (shipments[i] != null)
                {
                    Console.WriteLine($"{shipments[i].GetType().Name}");
                    Console.WriteLine(" ");
                    Console.WriteLine(shipments[i].PrintShipment());
                }
                else
                {
                    Console.WriteLine("No shipment to display");
                    break;
                }
            }


        }


        // object of type ITrackable can use GetTrackingStatus() 
        public void PrintShipment(ITrackable shipment) {

            Console.WriteLine("Tracking Status");

            if (shipment != null)
            {
                Console.WriteLine(shipment.GetTrackingStatus());
            }

            Console.WriteLine("================================");

        }

        // object of type IInsurable can use CalculateInsurance() 

        public void PrintInsurance(IInsurable shipment)
        {

            Console.WriteLine("Insurance");
            if (shipment != null)
            {
                Console.WriteLine($"{shipment.GetType().Name} Insurance Cost: {shipment.CalculateInsurance():F02} EGP");
            }
            Console.WriteLine("================================");

        }


        public void PrintTrackingStatuses()
        { 
          
         for (int i =0; i < shipmentCount; i++)
            {
                // StandardShipment implements ITrackable? yes -->  ITrackable trackable = StandardShipment shipments[i]
                // trackable can use GetTrackingStatus
                // object of type Shipment doesn't have GetTrackingStatus() but Standard, Express, International Shipment implements ITrackable
                if (shipments[i] != null && shipments[i] is ITrackable trackable)
                    Console.WriteLine(trackable.GetTrackingStatus());
                    Console.WriteLine(" ");

            }

        }

        public void PrintInsuranceCosts()
        {

            for (int i = 0; i < shipmentCount; i++)
            {
                if (shipments[i] != null && shipments[i] is IInsurable insurable)
                    Console.WriteLine(insurable.CalculateInsurance());
                    Console.WriteLine(" ");

            }

        }


        

        public void printShipmentByTrackingCode()
        {
            for (int i = 0; i < shipmentCount; i++)
            {
                if (shipments[i] != null)
                {
                    // Even though the array sees them as Shipment, each object still has its real type.
                    Console.WriteLine(shipments[i].trackingCode);
                }

            }
        }

    }
}
