namespace OpenTl.Schema.Tests
{
    using System;
    using System.Runtime.InteropServices.ComTypes;
    using System.Text;

    using DotNetty.Buffers;

    using OpenTl.Schema.Serialization;

    using Xunit;

    public sealed class BugTests
    {
        public static byte[] StringToByteArray(string hex)
        {
            var numberChars = hex.Length;
            var bytes = new byte[numberChars / 2];
            for (var i = 0; i < numberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }
        [Fact]
        public void Test1()
        {
            var str = @"DCF8F1730200000001C04D65C828D85A4D000000A8000000016D5CF3D01F42A1C928D85A4042AE7415C4B51C03000000D6BF904E9803000040FF431349D2206A7FF31442AD0FE54898030000D904BA623DB4F944024400009803000032E5DDBDAD0FE548C828D85A01610000010000009E0300000100000015C4B51C0000000015C4B51C0100000015710B4521200000AD0FE548159D809EA46AEB6C0E626561757479206368616E6E656C001C01C13788EB5F5A00000000C728D85A0000000001804E65C828D85A4E0000005400000059B4D66215C4B51C09000000D41F02A2C928D85AD81FC2A3C928D85ADC1F82A4C928D85AE01F02A5C928D85AE41FC2A5C928D85AE81F82A6C928D85AEC1F82A7C928D85AF01F42A8C928D85AF41F02A9C928D85A";

            var buffer = PooledByteBufferAllocator.Default.Buffer();
            buffer.WriteBytes(StringToByteArray(str));

            var obj = Serializer.Deserialize(buffer);
        } 
    }
}