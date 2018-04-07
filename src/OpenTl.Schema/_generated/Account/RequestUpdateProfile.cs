// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x78515775)]
    public sealed class RequestUpdateProfile : IRequest<OpenTl.Schema.IUser>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       /// <summary>Binary representation for the 'FirstName' property</summary>
       [SerializationOrder(1)]
       [CanSerialize("Flags", 0)]
       public byte[] FirstNameAsBinary { get => _FirstNameAsBinary; set { _FirstName = Encoding.UTF8.GetString(value); _FirstNameAsBinary = value; }}
       private byte[] _FirstNameAsBinary;
       private string _FirstName;
       public string FirstName { get => _FirstName; set { FirstNameAsBinary = Encoding.UTF8.GetBytes(value); _FirstName = value; }}

       /// <summary>Binary representation for the 'LastName' property</summary>
       [SerializationOrder(2)]
       [CanSerialize("Flags", 1)]
       public byte[] LastNameAsBinary { get => _LastNameAsBinary; set { _LastName = Encoding.UTF8.GetString(value); _LastNameAsBinary = value; }}
       private byte[] _LastNameAsBinary;
       private string _LastName;
       public string LastName { get => _LastName; set { LastNameAsBinary = Encoding.UTF8.GetBytes(value); _LastName = value; }}

       /// <summary>Binary representation for the 'About' property</summary>
       [SerializationOrder(3)]
       [CanSerialize("Flags", 2)]
       public byte[] AboutAsBinary { get => _AboutAsBinary; set { _About = Encoding.UTF8.GetString(value); _AboutAsBinary = value; }}
       private byte[] _AboutAsBinary;
       private string _About;
       public string About { get => _About; set { AboutAsBinary = Encoding.UTF8.GetBytes(value); _About = value; }}

    }
}
