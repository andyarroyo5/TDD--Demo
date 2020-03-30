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
                new Quote{ PackageName=Package.Limited,ExpirationDate=DateTime.Now.AddDays(120) },
                new Quote{ PackageName=Package.Extended,ExpirationDate=DateTime.Now.AddDays(50) },
                new Quote{ PackageName=Package.Integral,ExpirationDate=DateTime.Now.AddDays(30) }
            };
        }

        public ActionResult<List<Quote>> Get(Car car, Location location)
        {
            return null;
        }
    }
}
