namespace OpenTl.Schema.Serialization
{
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
            var bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }
        
        public static string GetStringFromBinary(byte[] bytes)
        {
            var length = bytes.Length / sizeof(char) + (bytes.Length % sizeof(char) != 0 ? 1 : 0);
            var chars = new char[length];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }
    }
}