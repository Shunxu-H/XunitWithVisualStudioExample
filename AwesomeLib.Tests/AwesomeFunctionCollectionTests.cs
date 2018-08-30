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

        // replace for SetUp in NUnit
        public AwesomeFunctionCollectionTests()
        {
            // you set up your resources here 
        }

        [Fact] // has to be marked fact
        public void Dispose() // this is equivalent to TearDown in NUnit
        {
            // do your clean up here 
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(3, 3)]
        [InlineData(2, 1)] // this case will fail
        public void InlineArgumentExample(int i1, int i2)
        {
            Assert.True(i1 == i2); 
        }
    }
}
