

namespace BusinessClock.IntegrationTests
{
    public class DemoTests
    {
        [Fact]
        public void CanAddTwoNumbers()
        {
            // Given
            int a = 10, b = 20, answer;
            // Whenn
            answer = a + b; //system under test (SUT)   

            //Then
           Assert.Equal(30, answer);

        }
        [Theory]
        [InlineData(10,20,30)] //essnetiall just some paramters to test with
        [InlineData(2,2,4)] // go into position of each parameter (a,b,expected)
        public void CanAddAnyTwoNumbers(int a, int b,int expected)
        {
            int answer = a + b;
            Assert.Equal(expected, answer);
        }
    }
}
