// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: carrinho.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace NSE.Carrinho.API.Services.gRPC {
  public static partial class CarrinhoCompras
  {
    static readonly string __ServiceName = "CarrinhoAPI.CarrinhoCompras";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::NSE.Carrinho.API.Services.gRPC.ObterCarrinhoRequest> __Marshaller_CarrinhoAPI_ObterCarrinhoRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::NSE.Carrinho.API.Services.gRPC.ObterCarrinhoRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::NSE.Carrinho.API.Services.gRPC.CarrinhoClienteResponse> __Marshaller_CarrinhoAPI_CarrinhoClienteResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::NSE.Carrinho.API.Services.gRPC.CarrinhoClienteResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::NSE.Carrinho.API.Services.gRPC.ObterCarrinhoRequest, global::NSE.Carrinho.API.Services.gRPC.CarrinhoClienteResponse> __Method_ObterCarrinho = new grpc::Method<global::NSE.Carrinho.API.Services.gRPC.ObterCarrinhoRequest, global::NSE.Carrinho.API.Services.gRPC.CarrinhoClienteResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ObterCarrinho",
        __Marshaller_CarrinhoAPI_ObterCarrinhoRequest,
        __Marshaller_CarrinhoAPI_CarrinhoClienteResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::NSE.Carrinho.API.Services.gRPC.CarrinhoReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for CarrinhoCompras</summary>
    public partial class CarrinhoComprasClient : grpc::ClientBase<CarrinhoComprasClient>
    {
      /// <summary>Creates a new client for CarrinhoCompras</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public CarrinhoComprasClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CarrinhoCompras that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public CarrinhoComprasClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected CarrinhoComprasClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected CarrinhoComprasClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::NSE.Carrinho.API.Services.gRPC.CarrinhoClienteResponse ObterCarrinho(global::NSE.Carrinho.API.Services.gRPC.ObterCarrinhoRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ObterCarrinho(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::NSE.Carrinho.API.Services.gRPC.CarrinhoClienteResponse ObterCarrinho(global::NSE.Carrinho.API.Services.gRPC.ObterCarrinhoRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ObterCarrinho, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::NSE.Carrinho.API.Services.gRPC.CarrinhoClienteResponse> ObterCarrinhoAsync(global::NSE.Carrinho.API.Services.gRPC.ObterCarrinhoRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ObterCarrinhoAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::NSE.Carrinho.API.Services.gRPC.CarrinhoClienteResponse> ObterCarrinhoAsync(global::NSE.Carrinho.API.Services.gRPC.ObterCarrinhoRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ObterCarrinho, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override CarrinhoComprasClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CarrinhoComprasClient(configuration);
      }
    }

  }
}
#endregion