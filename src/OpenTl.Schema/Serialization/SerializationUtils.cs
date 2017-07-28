namespace OpenTl.Schema.Serialization
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;

    public class SerializationUtils
    {
        private static readonly Encoding LatinEncoding = Encoding.GetEncoding("Latin1");

        public static byte[] GetBytes(string str)
        {
            return Encoding.UTF8.GetBytes(str);
        }

        public static string GetString(byte[] bytes)
        {
            return Encoding.UTF8.GetString(bytes);
        }

        public static byte[] GetBinaryFromString(string str)
        {
            var bytes = LatinEncoding.GetBytes(str);

            var decodedString = LatinEncoding.GetString(bytes);

            Debug.Assert(str == decodedString);

            return bytes;
        }

        public static string GetStringFromBinary(byte[] bytes)
        {
            var str = LatinEncoding.GetString(bytes);

            var decodedBytes = LatinEncoding.GetBytes(str);

            Debug.Assert(bytes.Length == decodedBytes.Length);

            for (var i = 0; i < bytes.Length; i++)
            {
                Debug.Assert(bytes[i] == decodedBytes[i]);
            }

            return str;
        }
    }
}