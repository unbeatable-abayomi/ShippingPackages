using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingPackages
{
    class OvernightPackage: TwoDayPackage
    {

        public OvernightPackage(string sender, string recipent, string senderaddress, string recipentaddress, decimal hourrate, double mintuesWrk) : base(sender, recipent, senderaddress, recipentaddress,hourrate,mintuesWrk)
        {

        }



        public override decimal CalculateCost()
        {
            return 24 * HourlyRate;
        }


        public override string ToString()
        {
            return $"\n Recipient Name:{Recipent}\n Recipient Address: {RecipentAddress}\n Sender Name: {Sender}\n Sender Address: {SenderAddress}\n Total Cost: {CalculateCost():C}";
        }
    }
}
