using System;
using System.Collections.Generic;
using System.Text;

namespace G_ASP_NET_83_OOP05
{

    // Partial Shipment Class 
    public abstract partial class Shipment
    {

        private string Status;

        public string status
            {
                get { return Status; }

                set
                {

                    if (!string.IsNullOrEmpty(value))
                    {

                        Status = value;
                    }
                }
            }


        // Partial Method
        public partial void OnTrackingStatusChanged(string newStatus) {
            Console.WriteLine($"Tracking status changed to: {newStatus}");
        }
        
        

        // Partial method declaration
            public string GetTrackingStatus() { 
                return Status;
        
            }
            public void UpdateTrackingStatus(string newStatus)
            {
                if (!string.IsNullOrWhiteSpace(newStatus))
                {
                    Status = newStatus;
                OnTrackingStatusChanged(newStatus);

                }
        }
    }
}

