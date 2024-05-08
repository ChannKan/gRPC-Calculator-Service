
namespace GrpcCalculatorService.Tests
{
    
    public class CalculatorImpTests
    {
        [Fact]
        public void Calculation_Plus_Success()
        {
            // Arrange
            string expectedResult = String.Format(" {0} + {1} = {2} ", 8, 8, 16);
            CalculatorImp calculator = new CalculatorImp();

            // Act
            string result = calculator.Calculation(8, 8, "plus");

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Calculation_Minus_Success()
        {
            // Arrange
            string expectedResult = String.Format(" {0} - {1} = {2} ", 8, 7, 1);
            CalculatorImp calculator = new CalculatorImp();

            // Act
            string result = calculator.Calculation(8, 7, "Minus");

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Calculation_Multiply_Success()
        {
            // Arrange
            string expectedResult = String.Format(" {0} * {1} = {2} ", 2, 7, 14);
            CalculatorImp calculator = new CalculatorImp();

            // Act
            string result = calculator.Calculation(2, 7, "Multiply");

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Calculation_Divide_Success()
        {
            // Arrange
            string expectedResult = String.Format(" {0} / {1} = {2} ", 14, 7, 2);
            CalculatorImp calculator = new CalculatorImp();

            // Act
            string result = calculator.Calculation(14, 7, "Divide");

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Calculation_Case_Insensitive_Success()
        {
            // Arrange
            string expectedResult = String.Format(" {0} / {1} = {2} ", 14, 7, 2);
            CalculatorImp calculator = new CalculatorImp();

            // Act
            string result = calculator.Calculation(14, 7, "dIvIde");

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}