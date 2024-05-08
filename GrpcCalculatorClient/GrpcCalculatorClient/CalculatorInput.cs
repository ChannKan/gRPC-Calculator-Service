namespace GrpcCalculatorClient
{
    internal class CalculatorInput
    {
        public enum MathOperator { PLUS, MINUS, MULTIPLY, DIVIDE };

        //Input data for calculation
        public OperationRequest GetInputData() 
        {
            OperationRequest operationRequest = null;
            var mathOperator = string.Empty;
            int leftnum = 0, rightNum = 0;
            try
            {
                while (operationRequest == null)
                {
                    //Get operator
                    Console.WriteLine("Please enter an operator for the calculation." +
                   " \nOperators can be plus, minus, multiply or divide." +
                   " \nTo exit press X ");
                    mathOperator = Console.ReadLine();

                    //Input validity check
                    if (string.IsNullOrWhiteSpace(mathOperator))
                    {
                        Console.WriteLine("Input cannot be empty");
                        continue;
                    }

                    mathOperator = mathOperator.ToUpper();

                    if (mathOperator == "X")
                        return null;

                    if (!MathOperator.IsDefined(typeof(MathOperator), mathOperator))
                    {
                        Console.WriteLine("Input must be an operator");
                        continue;
                    }

                    //Get the numbers for the calculation
                    Console.WriteLine("Please enter the first number for the calculation," +
                                      " \nThe number must be a whole number.");
                    //Input validity check
                    if (!int.TryParse(Console.ReadLine(), out leftnum))
                    {
                        Console.WriteLine("The number MUST be a whole number only");
                        continue;
                    }

                    Console.WriteLine("Please enter the second number for the calculation," +
                                     " \nThe number must be a whole number.");
                    //Input validity check
                    if (!int.TryParse(Console.ReadLine(), out rightNum))
                    {
                        Console.WriteLine("The number MUST be a whole number only");
                        continue;
                    }

                    //All input is correct, create a request
                    operationRequest = new OperationRequest();
                    operationRequest.Operator = mathOperator;
                    operationRequest.Left = leftnum;
                    operationRequest.Right = rightNum;
                }
            }
            catch
            {
                operationRequest = null;
            }
            
            return operationRequest;
           
        }


    }
}
