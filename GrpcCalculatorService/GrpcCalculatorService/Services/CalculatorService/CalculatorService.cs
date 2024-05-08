using Grpc.Core;
using GrpcCalculatorService;
using static GrpcCalculatorService.CalculatorService;

public class CalculatorService : CalculatorServiceBase
{
    private CalculatorImp calculator = new CalculatorImp();
  
    public override Task<OperationResponse> CalculatorOperation(OperationRequest request, ServerCallContext context)
    {
        return Task.FromResult(new OperationResponse
        {
            Result = calculator.Calculation(request.Left, request.Right, request.Operator)
        });
    }
}

