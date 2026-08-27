using System;
using System.Collections.Generic;
using System.Text;

namespace G_ASP_NET_83_OOP05
{
    public class Search
    {
        public static int BinarySearch(string trackingCode, Shipment[] shipments, int shipmentCount)
        {
            Array.Sort(shipments);

            int left = 0;
            int right = shipmentCount - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                int comparison = string.Compare(
                    shipments[mid].trackingCode,
                    trackingCode,
                    StringComparison.Ordinal);

                if (comparison == 0)
                {
                    return mid;
                }
                else if (comparison < 0)
                {
                    // Target is on the right
                    left = mid + 1;
                }
                else
                {
                    // Target is on the left
                    right = mid - 1;
                }
            }

            return -1;
        }

    }
}
