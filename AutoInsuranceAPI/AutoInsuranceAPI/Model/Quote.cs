using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoInsuranceAPI.Model
{
    public class Quote
    {        

        public Car Car { get; set; }
        public Location Location { get; set; }
        public Dictionary<string, double> Coverage { get; set; }
        public double Price { get; set; }
        public DateTime ExpirationDate { get; set; }
        public TypePayment TypePayment { get; set; }
        public Package PackageName { get; set; }

    }

    //Included as part of example 
    public enum Location
    {
        Monterrey,
        CDMX,
        Guadalajara
    }

    public enum TypePayment
    {
        Monthly,
        SemiAnnual,
        Anually
    }

    public enum Package
    {
        Limited,
        Extended,
        Integral
    }

}
