using Grpc.Core;
using GrpcDemo.Common;
using Server;

namespace Server.Services
{
    public class GreeterService : Greeter.GreeterBase
    {
        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = $"Hello {request.Name}, from gRPC server!"
            });
        }
    }
}
