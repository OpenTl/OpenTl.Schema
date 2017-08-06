// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x1e8caaeb)]
	public class TPostAddress : IPostAddress
	{
       [SerializationOrder(0)]
       public byte[] StreetLine1AsBinary { get => _StreetLine1AsBinary; set { _StreetLine1 = Encoding.UTF8.GetString(value); _StreetLine1AsBinary = value; }}
       private byte[] _StreetLine1AsBinary;
       private string _StreetLine1;
       public string StreetLine1 { get => _StreetLine1; set { StreetLine1AsBinary = Encoding.UTF8.GetBytes(value); _StreetLine1 = value; }}

       [SerializationOrder(1)]
       public byte[] StreetLine2AsBinary { get => _StreetLine2AsBinary; set { _StreetLine2 = Encoding.UTF8.GetString(value); _StreetLine2AsBinary = value; }}
       private byte[] _StreetLine2AsBinary;
       private string _StreetLine2;
       public string StreetLine2 { get => _StreetLine2; set { StreetLine2AsBinary = Encoding.UTF8.GetBytes(value); _StreetLine2 = value; }}

       [SerializationOrder(2)]
       public byte[] CityAsBinary { get => _CityAsBinary; set { _City = Encoding.UTF8.GetString(value); _CityAsBinary = value; }}
       private byte[] _CityAsBinary;
       private string _City;
       public string City { get => _City; set { CityAsBinary = Encoding.UTF8.GetBytes(value); _City = value; }}

       [SerializationOrder(3)]
       public byte[] StateAsBinary { get => _StateAsBinary; set { _State = Encoding.UTF8.GetString(value); _StateAsBinary = value; }}
       private byte[] _StateAsBinary;
       private string _State;
       public string State { get => _State; set { StateAsBinary = Encoding.UTF8.GetBytes(value); _State = value; }}

       [SerializationOrder(4)]
       public byte[] CountryIso2AsBinary { get => _CountryIso2AsBinary; set { _CountryIso2 = Encoding.UTF8.GetString(value); _CountryIso2AsBinary = value; }}
       private byte[] _CountryIso2AsBinary;
       private string _CountryIso2;
       public string CountryIso2 { get => _CountryIso2; set { CountryIso2AsBinary = Encoding.UTF8.GetBytes(value); _CountryIso2 = value; }}

       [SerializationOrder(5)]
       public byte[] PostCodeAsBinary { get => _PostCodeAsBinary; set { _PostCode = Encoding.UTF8.GetString(value); _PostCodeAsBinary = value; }}
       private byte[] _PostCodeAsBinary;
       private string _PostCode;
       public string PostCode { get => _PostCode; set { PostCodeAsBinary = Encoding.UTF8.GetBytes(value); _PostCode = value; }}

	}
}
