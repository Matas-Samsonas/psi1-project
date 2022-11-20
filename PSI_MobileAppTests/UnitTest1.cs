using Bunit;

namespace PSI_MobileAppTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        [Fact]
        public void Sidebar_Navigation_Should_Work()
        {
            using var ctx = new TestContext();
            var cut = ctx.RenderComponent<PSI_MobileApp.Pages.Counter>();

            cut.Find("button").Click();

            Assert.Equal("Click me", cut.Find($".btn").TextContent);
        }
    }
}