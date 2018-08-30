using Xunit; 

namespace AwesomeLib.Tests
{
    public class AwesomeFunctionCollectionTests
    {
        [Fact]
        public void GetAwesomeStringTest()
        {
            Assert.True(AwesomeFunctionCollection.AwesomeString == AwesomeFunctionCollection.GetAwesomeString()); 
        }
    }
}
