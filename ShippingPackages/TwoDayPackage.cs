using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingPackages
{
    class TwoDayPackage:Package
    {
        private decimal hourlyRate;
        private double miuntesWorkedOnPackage;
        public TwoDayPackage (string sender,string recipent, string senderaddress, string recipentaddress, decimal hourrate,double mintuesWrk) : base(sender, recipent, senderaddress, recipentaddress)
        {
            HourlyRate = hourrate;
            MiuntesWorkedOnPackage = mintuesWrk;
        }

        public decimal HourlyRate
        {
            get { return hourlyRate; }
            set
            {
                if(value > 0.0M)
                {
                    hourlyRate = value;
                }
            }
        }

        public double MiuntesWorkedOnPackage
        {
            get { return miuntesWorkedOnPackage; }
            set
            {
                if( value > 0.0)
                {
                    miuntesWorkedOnPackage = value;
                }
            }
        }

        public override decimal CalculateCost()
        {
            return (decimal)(MiuntesWorkedOnPackage/60) * HourlyRate;
        }

        public override string ToString()
        {
            return $"Two Day Package: \n Recipient Name:{Recipent}\n Recipient Address: {RecipentAddress}\n Sender Name: {Sender}\n Sender Address: {SenderAddress}\n Total Cost: {CalculateCost():C}";
        }
    }
}
