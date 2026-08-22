using System;
using System.Collections.Generic;
using System.Text;

namespace G_ASP_NET_83_OOP05
{
    public class DeliveryAddress
    {

        // Fields/ Variables/ Attributes
        private string City;
        private string Street;
        private int BuildingNumber;

        // Constructor


        //  GetFullAddress() : returns the complete address as one string.

        public string GetFullAddress()
        {
            return $"{BuildingNumber} {Street}, {City}";
        }
        public string city
        {

            get => City;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    City = value;
                }
                else
                {
                    Console.WriteLine("City cannot be null or empty.");
                }
            }
        }

        public string street
        {
            get => Street;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    Street = value;
                }
                else
                {
                    Console.WriteLine("Street cannot be null or empty.");
                }
            }
        }


        public int buildingNumber
        {

            get => BuildingNumber;
            set
            {
                if (value > 0 )
                {
                    BuildingNumber = value;
                }
                else
                {
                    Console.WriteLine("Building number must be a positive integer.");
                }
            }
        }


        public DeliveryAddress(string City, string Street, int BuildingNumber)
        {
            this.City = !string.IsNullOrWhiteSpace(City) ? City : "Unknown";
            this.Street = !string.IsNullOrWhiteSpace(Street) ? Street : "Unknown";
            this.BuildingNumber = BuildingNumber > 0 ? BuildingNumber : 1;
        }


    }
}
