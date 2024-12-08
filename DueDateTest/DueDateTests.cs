using Xunit;
using DueDateCalulator;
namespace DueDateTest
{
    public class DueDateTests
    {
        [Fact]
        public void DueDateTest1()
        {
            DateCalculator calculator = new DateCalculator();
            DateTime testDate = calculator.CalculateDueDate(new DateTime(2024, 12, 10, 14, 2, 0), TimeSpan.FromHours(16));
            
            Assert.Equal(new DateTime(2024, 12, 12, 14, 2, 0), testDate);
        }
        [Fact]
        public void DueDateTest2()
        {
            DateCalculator calculator = new DateCalculator();
            DateTime testDate = calculator.CalculateDueDate(new DateTime(2024, 12, 10, 14, 2, 0), TimeSpan.FromHours(20));
            
            Assert.Equal(new DateTime(2024, 12, 13, 10, 2, 0), testDate);
        }
        [Fact]
        public void DueDateTest3()
        {
            DateCalculator calculator = new DateCalculator();
            DateTime testDate = calculator.CalculateDueDate(new DateTime(2024, 12, 10, 14, 2, 0), TimeSpan.FromHours(24));
            
            Assert.Equal(new DateTime(2024, 12, 13, 14, 2, 0), testDate);
        }
        [Fact]
        public void DueDateTest4()
        {
            DateCalculator calculator = new DateCalculator();
            DateTime testDate = calculator.CalculateDueDate(new DateTime(2024, 12, 10, 14, 2, 0), TimeSpan.FromHours(5));
            
            Assert.Equal(new DateTime(2024, 12, 11, 11, 2, 0), testDate);
        }
        [Fact]
        public void DueDateTest5()
        {
            DateCalculator calculator = new DateCalculator();
            DateTime testDate = calculator.CalculateDueDate(new DateTime(2024, 12, 10, 14, 2, 0), TimeSpan.FromHours(2));
           
            Assert.Equal(new DateTime(2024, 12, 10, 16, 2, 0), testDate);
        }
        [Fact]
        public void DueDateTest6()
        {
            DateCalculator calculator = new DateCalculator();
            DateTime testDate = calculator.CalculateDueDate(new DateTime(2024, 12, 10, 14, 2, 0), TimeSpan.FromHours(3));
           
            Assert.Equal(new DateTime(2024, 12, 11, 9, 2, 0), testDate);
        }
        [Fact]
        public void DueDateTest7()
        {
            DateCalculator calculator = new DateCalculator();
            DateTime testDate = calculator.CalculateDueDate(new DateTime(2024, 12, 10, 14, 2, 0), TimeSpan.FromHours(30));
            
            Assert.Equal(new DateTime(2024, 12, 14, 12, 2, 0), testDate);
        }
    }
}