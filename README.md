GrpcDemo/
│
├─ GrpcDemo.Common/          # 公共库，存放 proto、DTO、共享逻辑
│   ├─ Protos/
│   │   └─ 

│   ├─ greeter.proto

│   └─ GrpcDemo.Common.csproj
│
├─ GrpcDemo.Server/          # gRPC 服务端
│   ├─ Services/
│   │   └─ GreeterService.cs

│   ├─ Properties/

│   │   └─launchSettings.json  #记录了grpc服务url

│   └─ GrpcDemo.Server.csproj
│
├─ GrpcDemo.Client/          # gRPC 客户端
│   └─ Program.cs
│   └─ GrpcDemo.Client.csproj
│
└─ GrpcDemo.sln



### 一.Common.Grpc

需要安装Google.Protobuf，Grpc.Tools，Grpc.Net.Client Nugut包

1. 定义proto文件，右键-新建，选择文本文件，后缀名改为.proto即可。
2. 编译proto文件，右键proto文件，选择属性，设置如下：

​	Build Action ：Protobuf compiler

​	gRPC Stub Classes ：Client and Server

设置好了后，生成项目即可。