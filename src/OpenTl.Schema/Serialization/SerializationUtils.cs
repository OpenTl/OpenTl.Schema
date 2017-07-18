namespace OpenTl.Schema.Serialization
{
    using System;
    using System.Linq;
    using System.Text;

    public class SerializationUtils
    {
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
            return str.Select(Convert.ToByte).ToArray();
        }
        
        public static string GetStringFromBinary(byte[] bytes)
        {
            var chars = bytes.Select(Convert.ToChar).ToArray();
            
            return new string(chars);
        }
    }
}