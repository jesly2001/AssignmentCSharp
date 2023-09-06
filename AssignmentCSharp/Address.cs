using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentCSharp
{
    public class Address
    {
        
            private int pincode;



            public string AddressLine1 { get; set; }
            public string AddressLine2 { get; set; }
            public string City { get; set; }
            public int Pincode
            {
                get { return pincode; }
                set
                {
                    if (value >= 0 && value <= 999999)
                    {
                        pincode = value;
                    }
                    else
                    {
                        pincode = 570010;
                    }
                }
            }



            public Address(string addressLine1, string addressLine2, string city, int pincode)
            {
                AddressLine1 = addressLine1;
                AddressLine2 = addressLine2;
                City = city;
                Pincode = pincode;
            }
        }
}
