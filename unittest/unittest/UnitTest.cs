using Xunit;

namespace Namespace
{
    public class UnitTest
    {
        [Fact]
        public void UnitTestPassingTest()
        {
            Assert.Equal(4, (2 + 2));
        }
        
        [Fact]
        public void UnitTestFailingTest()
        {
            Assert.Equal(5, (2 + 2));
        }
    }
}
