using Grpc.Net.Client;
using GrpcCalculatorClient;


// The port number must match the port of the gRPC server.
using var channel = GrpcChannel.ForAddress("https://localhost:7212");
var client = new CalculatorService.CalculatorServiceClient(channel);
CalculatorInput calculator = new CalculatorInput();

try
{
    //Get data for first calculation 
    var dataInput = calculator.GetInputData();

    while (dataInput != null) //Running the calculator
    {
        //Sending data to the calculator
        var calculationResult = await client.CalculatorOperationAsync(dataInput);

        //Print calculation result
        Console.WriteLine(calculationResult.Result);

        //Get data for next calculation 
        dataInput = calculator.GetInputData();
    }
}
catch
{
    return;
}

 



