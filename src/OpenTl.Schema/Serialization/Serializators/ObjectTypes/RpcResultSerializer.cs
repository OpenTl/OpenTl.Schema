namespace OpenTl.Schema.Serialization.Serializators.ObjectTypes
{
    using System.Reflection;

    using DotNetty.Buffers;

    using OpenTl.Common.Extensions;
    using OpenTl.Schema.Serialization.Serializators.Interfaces;

    internal class RpcResultSerializer : ISerializator
    {
        public TypeInfo SupportedType { get; } = typeof(TRpcResult).GetTypeInfo();

        public object Deserialize(IByteBuffer buffer, SerializationMetadata metadata)
        {
            var rpcResult = new TRpcResult
                            {
                                ReqMsgId = buffer.ReadLongLE(),
                                Result = buffer.ToArray()
                            };

            return rpcResult;
        }

        public void Serialize(object value, IByteBuffer buffer, SerializationMetadata metadata)
        {
            var rpcResult = (TRpcResult)value;

            buffer.WriteLongLE(rpcResult.ReqMsgId);
            buffer.WriteBytes(rpcResult.Result);
        }
    }
}