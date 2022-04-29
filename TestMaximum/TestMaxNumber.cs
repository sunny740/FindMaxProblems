using FindMaxNum;
using NUnit.Framework;

namespace TestMaximum
{
    public class TestMaxNumber
    {
        [Test]
        public void GivenIntInput_WhenTestmax_ShouldReturnMaxNum()
        {
            MaxNumber max = new MaxNumber();
            int actual = max.FindMaxInteger(1, 2, 3);
            Assert.AreEqual(actual, 3);
        }
    }
}