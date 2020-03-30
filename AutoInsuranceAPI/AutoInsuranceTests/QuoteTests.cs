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
            //fill 
            var car = new Car {
                Year=2016,
                Model="Vento"
            };

            var location = "CDMX";
            
            //act
            var result = _quoteController.Get();

            //assert
            var model = Assert.IsAssignableFrom<ActionResult<List<Quote>>(result);
            Assert.Equal(3, model.Value.Count);
        }
    }
}
