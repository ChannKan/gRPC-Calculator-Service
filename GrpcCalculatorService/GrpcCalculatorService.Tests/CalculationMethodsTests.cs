
namespace GrpcCalculatorService.Tests
{
    public class CalculationMethodsTests
    {
        [Fact]
        public void Plus_Add_Success()
        {
            // Arrange
            string expectedResult = String.Format(" {0} + {1} = {2} ", 6, 6, 12);
       
            // Act
            string result = CalculationMethods.Plus(6, 6);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Plus_Add_Failure()
        {
            // Arrange
            string expectedResult = String.Format(" {0} - {1} = {2} ", 6, 6, 12);

            // Act
            string result = CalculationMethods.Plus(6, 6);

            // Assert
            Assert.NotEqual(expectedResult, result);
        }

        [Fact]
        public void Plus_Equals_Zero_Success()
        {
            // Arrange
            string expectedResult = String.Format(" {0} + {1} = {2} ", 6, -6, 0);

            // Act
            string result = CalculationMethods.Plus(6, -6);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Plus_IntOverflow_Success()
        {
            // Arrange
            string expectedResultMax = String.Format(" {0} + {1} = {2} ", int.MaxValue, int.MaxValue, (long)int.MaxValue + int.MaxValue);
            string expectedResultMin = String.Format(" {0} + {1} = {2} ", int.MinValue, int.MinValue, (long)int.MinValue + int.MinValue);

            // Act
            string resultMax = CalculationMethods.Plus(int.MaxValue, int.MaxValue);
            string resultMin = CalculationMethods.Plus(int.MinValue, int.MinValue);

            // Assert
            Assert.Equal(expectedResultMax, resultMax);
            Assert.Equal(expectedResultMin, resultMin);
        }

        [Fact]
        public void Minus_Sub_Failure()
        {
            // Arrange
            string expectedResult = String.Format(" {0} + {1} = {2} ", 6, 5, 1);

            // Act
            string result = CalculationMethods.Minus(6, 5);

            // Assert
            Assert.NotEqual(expectedResult, result);
        }

        [Fact]
        public void Minus_Sub_Success()
        {
            // Arrange
            string expectedResult = String.Format(" {0} - {1} = {2} ", 6, 5, 1);

            // Act
            string result = CalculationMethods.Minus(6, 5);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Minus_Equals_Zero_Success()
        {
            // Arrange
            string expectedResult = String.Format(" {0} - {1} = {2} ", 6, 6, 0);

            // Act
            string result = CalculationMethods.Minus(6, 6);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Minus_MinusMinusPlus_Success()
        {
            // Arrange
            string expectedResult = String.Format(" {0} - {1} = {2} ", 6, -6, 12);

            // Act
            string result = CalculationMethods.Minus(6, -6);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Minus_Negative_Success()
        {
            // Arrange
            string expectedResult = String.Format(" {0} - {1} = {2} ", 6, 9, -3);

            // Act
            string result = CalculationMethods.Minus(6 , 9);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Multiply_Mult_Success()
        {
            // Arrange
            string expectedResult = String.Format(" {0} * {1} = {2} ", 6, 3, 18);

            // Act
            string result = CalculationMethods.Multiply(6, 3);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Multiply_Mult_Failure()
        {
            // Arrange
            string expectedResult = String.Format(" {0} - {1} = {2} ", 6, 3, 18);

            // Act
            string result = CalculationMethods.Multiply(6, 3);

            // Assert
            Assert.NotEqual(expectedResult, result);
        }

        [Fact]
        public void Multiply_Equals_Zero_Success()
        {
            // Arrange
            string expectedResult = String.Format(" {0} * {1} = {2} ", 6, 0, 0);

            // Act
            string result = CalculationMethods.Multiply(6, 0);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Multiply_Negative_Success()
        {
            // Arrange
            string expectedResult = String.Format(" {0} * {1} = {2} ", 6, -2, -12);

            // Act
            string result = CalculationMethods.Multiply(6, -2);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Multiply_MinusMinusPlus_Success()
        {
            // Arrange
            string expectedResult = String.Format(" {0} * {1} = {2} ", -6, -2, 12);

            // Act
            string result = CalculationMethods.Multiply(-6, -2);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Multiply_IntOverflow_Success()
        {
            // Arrange
            string expectedResultMax = String.Format(" {0} * {1} = {2} ", int.MaxValue, int.MaxValue, (long)int.MaxValue * int.MaxValue);
            string expectedResultMin = String.Format(" {0} * {1} = {2} ", int.MinValue, int.MinValue, (long)int.MinValue * int.MinValue);

            // Act
            string resultMax = CalculationMethods.Multiply(int.MaxValue, int.MaxValue);
            string resultMin = CalculationMethods.Multiply(int.MinValue, int.MinValue);

            // Assert
            Assert.Equal(expectedResultMax, resultMax);
            Assert.Equal(expectedResultMin, resultMin);
        }

        [Fact]
        public void Division_Div_Success()
        {
            // Arrange
            string expectedResult = String.Format(" {0} / {1} = {2} ", 6, 2, 3);

            // Act
            string result = CalculationMethods.Division(6, 2);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Division_Div_Failure()
        {
            // Arrange
            string expectedResult = String.Format(" {0} - {1} = {2} ", 6, 2, 3);

            // Act
            string result = CalculationMethods.Division(6, 2);

            // Assert
            Assert.NotEqual(expectedResult, result);
        }

        [Fact]
        public void Division_Equals_Zero_Success()
        {
            // Arrange
            string expectedResult = String.Format(" {0} / {1} = {2} ", 0, -2, 0);

            // Act
            string result = CalculationMethods.Division( 0, -2);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Division_ByZero_Success()
        {
            // Arrange
            string expectedResult = "Division by zero is an illegal operation";

            // Act
            string result = CalculationMethods.Division(-6, 0);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Division_MinusMinusPlus_Success()
        {
            // Arrange
            string expectedResult = String.Format(" {0} / {1} = {2} ", -6, -2, 3);

            // Act
            string result = CalculationMethods.Division(-6, -2);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Division_Minus_Success()
        {
            // Arrange
            string expectedResult = String.Format(" {0} / {1} = {2} ", -6, 2, -3);

            // Act
            string result = CalculationMethods.Division(-6, 2);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Division_DecimalResult_Success()
        {
            // Arrange
            string expectedResult = String.Format(" {0} / {1} = .67 ", 6, 9);

            // Act
            string result = CalculationMethods.Division(6, 9);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
