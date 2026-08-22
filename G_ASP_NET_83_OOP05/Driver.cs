using System;
using System.Collections.Generic;
using System.Text;

namespace G_ASP_NET_83_OOP05
{
    public class Driver
    {
        private int DriverId;
        private string FullName;
        private string PhoneNumber;

        // ============ Properties ================
        public int driverId {
            get { return DriverId; }
            set {
                if (DriverId > 0)
                    DriverId = value;
            }
        }

        public string fullName {
          get => FullName;
          set { 
               if(!string.IsNullOrEmpty(value))
                    FullName = value;
            }
        }

        public string phoneNumber
        {
            get { return PhoneNumber; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length == 11)
                    PhoneNumber = value;
            }
        }
        // ============================


        // Constructor
        public Driver(int DriverId, string FullName, string PhoneNumber) { 
            this.DriverId = DriverId > 0 ? DriverId: 1;
            this.FullName = !string.IsNullOrEmpty(FullName) ? FullName : "unknown";
            this.PhoneNumber = !string.IsNullOrEmpty(PhoneNumber) ? PhoneNumber : "unknown";
        }

    }

}
