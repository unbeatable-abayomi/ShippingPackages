using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingPackages
{
   public abstract class Package
    {   protected string  Sender { get; set; }
        protected string Recipent { get; set; }

        protected string SenderAddress { get; set; }

        protected string RecipentAddress { get; set; }


        public Package(string sender,string recipnt, string senderaddress, string recipentaddress )
        {
            Sender = sender;
            Recipent = recipnt;
            SenderAddress = senderaddress;
            RecipentAddress = recipentaddress;
        }
        public abstract decimal CalculateCost();
    }
}
