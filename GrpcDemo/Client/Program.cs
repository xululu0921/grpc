
using Grpc.Net.Client;
using GrpcDemo.Common;

Console.WriteLine("Connecting to gRPC server...");

using var channel = GrpcChannel.ForAddress("https://localhost:7015");
var client =  new Greeter.GreeterClient(channel);

while (true)
{
    Console.Write("Input name (exit to quit): ");
    var name = Console.ReadLine();

    if (name == "exit")
        break;

    var reply = await client.SayHelloAsync(new HelloRequest
    {
        Name = name
    });

    Console.WriteLine($"Server replied: {reply.Message}");
}
