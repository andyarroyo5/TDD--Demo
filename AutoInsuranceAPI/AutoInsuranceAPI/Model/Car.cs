using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoInsuranceAPI.Model
{
    public class Car
    {
        public Int32 Year { get; set; }

        public CarModels Model { get; set; }

    }

    public enum CarModels { 
        
        Vento,
        Tida, 
        Gol    
    }

   //Included as part of example 
    public enum Location
    {

        Monterrey,
        CDMX,
        Guadalajara
    }
}
