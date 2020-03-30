using AutoInsuranceAPI.Controllers;
using System;
using Xunit;

namespace AutoInsuranceTests
{
    public class QuoteTests
    {
        private readonly QuoteController _quoteController;

        public QuoteTests()
        {
            _quoteController = new QuoteController();
        }

        [Fact]
        public void GetTest_GetQuote()
        {

        }
    }
}
