using AutoInsuranceAPI.Controllers;
using AutoInsuranceAPI.Model;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace AutoInsuranceTests
{
    public class QuoteTests
    {
        private readonly QuoteController _quoteController;
        private Mock<List<Quote>> _mockQuoteList;

        public QuoteTests()
        {
            _mockQuoteList = new Mock<List<Quote>>();
            _quoteController = new QuoteController();
        }

        [Fact]
        public void GetTest_GetQuotes()
        {
            //arrange 
            var car = new Car {
                Year=2016,
                Model=CarModels.Vento
            };

            var location = Location.CDMX;
            
            //act
            var result = _quoteController.Get(car, location);

            //assert
            var model = Assert.IsAssignableFrom<ActionResult<List<Quote>>(result);
            Assert.Equal(3, model.Value.Count);
        }
    }
}
