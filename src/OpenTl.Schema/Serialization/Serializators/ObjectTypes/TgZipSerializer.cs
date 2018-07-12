using System;
using System.IO;
using System.IO.Compression;
using DotNetty.Common.Utilities;

namespace OpenTl.Schema.Serialization.Serializators.ObjectTypes
{
    using System.Reflection;

    using DotNetty.Buffers;

    using OpenTl.Common.Extensions;
    using OpenTl.Schema.Serialization.Serializators.Interfaces;

    internal class TgZipSerializer : ISerializator
    {
        public TypeInfo SupportedType { get; } = typeof(TgZipPacked).GetTypeInfo();

        public object Deserialize(IByteBuffer buffer, SerializationMetadata metadata)
        {
            var data = (byte[]) Serializer.Deserialize(buffer, typeof(byte[]));
            
            return UnzipPackage(data, metadata);
        }

        private object UnzipPackage(byte[] packedData, SerializationMetadata metadata)
        {
            using (var decompressStream = new MemoryStream())
            {
                using (var stream = new MemoryStream(packedData))
                using (var zipStream = new GZipStream(stream, CompressionMode.Decompress))
                {
                    zipStream.CopyTo(decompressStream);
                }

                decompressStream.Position = 0;

                var buffer = PooledByteBufferAllocator.Default.Buffer();

                try
                {
                    buffer.WriteBytes(decompressStream.ToArray());
                    
                    var unzippedObj = Serializer.Deserialize(buffer, metadata);

                    return unzippedObj;
                }
                finally
                {
                    buffer.SafeRelease();
                }
            }
        }

        public void Serialize(object value, IByteBuffer buffer, SerializationMetadata metadata)
        {
            throw new NotSupportedException();
        }
    }
}