namespace OpenTl.Common.Extensions
{
    using DotNetty.Buffers;

    public static class NettyExtensions
    {
        public static byte[] ToArray(this IByteBuffer buffer, int lenght)
        {
            var data = new byte[lenght];
            
            buffer.ReadBytes(data);
            
            return data;
        }
        
        public static byte[] ToArray(this IByteBuffer buffer)
        {
            var data = new byte[buffer.ReadableBytes];
            
            buffer.ReadBytes(data);
            
            return data;
        }
    }
}