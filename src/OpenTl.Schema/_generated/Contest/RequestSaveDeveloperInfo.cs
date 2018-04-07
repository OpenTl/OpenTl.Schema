// ReSharper disable All

namespace OpenTl.Schema.Contest
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9a5f6e95)]
    public sealed class RequestSaveDeveloperInfo : IRequest<bool>
    {
       [SerializationOrder(0)]
       public int VkId {get; set;}

       /// <summary>Binary representation for the 'Name' property</summary>
       [SerializationOrder(1)]
       public byte[] NameAsBinary { get => _NameAsBinary; set { _Name = Encoding.UTF8.GetString(value); _NameAsBinary = value; }}
       private byte[] _NameAsBinary;
       private string _Name;
       public string Name { get => _Name; set { NameAsBinary = Encoding.UTF8.GetBytes(value); _Name = value; }}

       /// <summary>Binary representation for the 'PhoneNumber' property</summary>
       [SerializationOrder(2)]
       public byte[] PhoneNumberAsBinary { get => _PhoneNumberAsBinary; set { _PhoneNumber = Encoding.UTF8.GetString(value); _PhoneNumberAsBinary = value; }}
       private byte[] _PhoneNumberAsBinary;
       private string _PhoneNumber;
       public string PhoneNumber { get => _PhoneNumber; set { PhoneNumberAsBinary = Encoding.UTF8.GetBytes(value); _PhoneNumber = value; }}

       [SerializationOrder(3)]
       public int Age {get; set;}

       /// <summary>Binary representation for the 'City' property</summary>
       [SerializationOrder(4)]
       public byte[] CityAsBinary { get => _CityAsBinary; set { _City = Encoding.UTF8.GetString(value); _CityAsBinary = value; }}
       private byte[] _CityAsBinary;
       private string _City;
       public string City { get => _City; set { CityAsBinary = Encoding.UTF8.GetBytes(value); _City = value; }}

    }
}
