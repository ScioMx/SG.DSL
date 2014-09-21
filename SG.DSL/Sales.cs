namespace SG.DSL
{
    using FluentAutomation;

    using Xunit;

    public class Sales : FluentTest
    {
        public Sales()
        {
            SeleniumWebDriver
                .Bootstrap(SeleniumWebDriver.Browser.Chrome);
        }

        [Fact]
        public void TestPage()
        {
            new SalesLoginPage(this)
                .Go()
                .Login(TestCase.UserName, TestCase.Password)
                .PlaceAnOrder();
        }
    }
}
