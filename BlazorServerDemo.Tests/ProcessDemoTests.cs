
namespace BlazorServerDemo.Tests
{
    /// <summary>
    /// Represents a test class for the <see cref="ProcessDemo"/> class.
    /// </summary>
    public class ProcessDemoTests
    {
        /// <summary>
        /// Tests the <see cref="ProcessDemo.GetDaysInMonth"/> method to ensure it returns the proper number of days for a leap year.
        /// </summary>
        /// <param name="dateTime">The input date and time.</param>
        /// <param name="expected">The expected number of days in the month.</param>
        [Theory]
        [InlineData("2023/03/10", 31)]
        [InlineData("2024/02/10", 29)]
        [InlineData("2000/02/10", 29)]
        [InlineData("2400/02/10", 29)]
        [InlineData("1900/02/10", 28)]
        [InlineData("1800/02/10", 28)]
        [InlineData("1700/02/10", 28)]
        public void GetDaysInMonth_ShouldReturnProperNumberForLeapYear(DateTime dateTime, int expected)
        {
            TestingDemo t = new(dateTime);
            ProcessDemo p = new(t);

            int actual = p.GetDaysInMonth();

            Assert.Equal(expected, actual);
        }
    }

    /// <summary>
    /// Represents a testing demo class that implements the <see cref="IDemo"/> interface.
    /// </summary>
    public class TestingDemo : IDemo
    {
        /// <summary>
        /// Gets or sets the startup time.
        /// </summary>
        public DateTime StartupTime { get; init; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestingDemo"/> class.
        /// </summary>
        /// <param name="startupTime">The startup time.</param>
        public TestingDemo(DateTime startupTime)
        {
            StartupTime = startupTime;
        }
    }
}