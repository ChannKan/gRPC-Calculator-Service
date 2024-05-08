namespace GrpcCalculatorService
{
    public class CalculationMethods
    {
        //Plus Calculation
        public static string Plus(int leftNum, int rightNum)
        {
            long answer = (long)leftNum + rightNum;
            string calculationString = String.Format(" {0} + {1} = {2} ", leftNum , rightNum , answer);

            return calculationString;
        }

        //Minus Calculation
        public static string Minus(int leftNum, int rightNum)
        {
            long answer = (long)leftNum - rightNum;
            string calculationString = String.Format(" {0} - {1} = {2} ", leftNum, rightNum, answer);

            return calculationString;
        }

        //Multiply Calculation
        public static string Multiply(int leftNum, int rightNum)
        {
            long answer = (long)leftNum * rightNum;
            string calculationString = String.Format(" {0} * {1} = {2} ", leftNum, rightNum, answer);

            return calculationString;
        }

        //Division Calculation
        public static string Division(int leftNum, int rightNum)
        {
            if (rightNum == 0)
                return "Division by zero is an illegal operation";

            double answer = (double)leftNum / rightNum;
            string calculationString = String.Format(" {0} / {1} = {2} " , leftNum, rightNum, answer.ToString("#.##;-#.##;0"));

            return calculationString;
        }
    }
}
