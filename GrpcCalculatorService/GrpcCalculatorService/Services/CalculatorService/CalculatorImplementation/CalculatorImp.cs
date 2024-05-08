namespace GrpcCalculatorService
{
    public class CalculatorImp
    {
        public enum MathOperator { Plus, Minus, Multiply, Divide };

        //Performing the calculation according to the received operator
        public string Calculation(int leftnum, int rightNum, string strigMathOperator )
        {
            MathOperator mathOperator;

            if(!Enum.TryParse(strigMathOperator, true, out mathOperator))
                return "The operator is invalid";   

            switch (mathOperator)
            {
                case MathOperator.Plus:
                    return CalculationMethods.Plus(leftnum, rightNum);
                case MathOperator.Minus:
                    return CalculationMethods.Minus(leftnum, rightNum);
                case MathOperator.Multiply:
                    return CalculationMethods.Multiply(leftnum, rightNum);
                case MathOperator.Divide:
                    return CalculationMethods.Division(leftnum, rightNum);
            };

            return string.Empty;
        }
    }
}
