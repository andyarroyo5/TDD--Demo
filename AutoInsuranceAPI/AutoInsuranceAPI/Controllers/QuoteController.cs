using AutoInsuranceAPI.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoInsuranceAPI.Controllers
{
    public class QuoteController
    {
        private readonly List<Quote> _quotes;

        public QuoteController()
        {
            _quotes = new List<Quote>
            {
                new Quote{ PackageName=Package.Limited,ExpirationDate=DateTime.Now.AddDays(30),Location=Location.CDMX, Car= new Car{ Model=CarModels.Vento,Year=2019 },Coverage=new Dictionary<string, double>{{ "Amparo Robo Total",300000 }, { "ACCIDENTES AUTOMOVILÍSTICOS AL CONDUCTO",100000.00 } } },
                new Quote{ PackageName=Package.Limited,ExpirationDate=DateTime.Now.AddDays(80),Location=Location.CDMX, Car= new Car{ Model=CarModels.Tida,Year=2019 }, Coverage=new Dictionary<string, double>{{ "Amparo Robo Total",300000 }, { "ACCIDENTES AUTOMOVILÍSTICOS AL CONDUCTO",100000.00 } } },
                new Quote{ PackageName=Package.Limited,ExpirationDate=DateTime.Now.AddDays(120),Location=Location.CDMX, Car= new Car{ Model=CarModels.Gol,Year=2019 }, Coverage=new Dictionary<string, double>{{ "Amparo Robo Total",300000 }, { "ACCIDENTES AUTOMOVILÍSTICOS AL CONDUCTO",100000.00 } } },
                new Quote{ PackageName=Package.Extended,ExpirationDate=DateTime.Now.AddDays(30),Location=Location.CDMX, Car= new Car{ Model=CarModels.Vento,Year=2017 },Coverage=new Dictionary<string, double>{{ "Amparo Robo Total",300000 }, { "ACCIDENTES AUTOMOVILÍSTICOS AL CONDUCTO",100000.00 } } },
                new Quote{ PackageName=Package.Integral,ExpirationDate=DateTime.Now.AddDays(80),Location=Location.CDMX, Car= new Car{ Model=CarModels.Tida,Year=2019 }, Coverage=new Dictionary<string, double>{{ "Amparo Robo Total",300000 }, { "ACCIDENTES AUTOMOVILÍSTICOS AL CONDUCTO",100000.00 } } },                
            };
        }

        public ActionResult<List<Quote>> Get(Car car, Location location)
        {
            return null;
        }
    }
}
