// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x8e1a1775)]
	public sealed class TNearestDc : INearestDc
	{
       /// <summary>Binary representation for the 'Country' property</summary>
       [SerializationOrder(0)]
       public byte[] CountryAsBinary { get => _CountryAsBinary; set { _Country = Encoding.UTF8.GetString(value); _CountryAsBinary = value; }}
       private byte[] _CountryAsBinary;
       private string _Country;
       public string Country { get => _Country; set { CountryAsBinary = Encoding.UTF8.GetBytes(value); _Country = value; }}

       [SerializationOrder(1)]
       public int ThisDc {get; set;}

       [SerializationOrder(2)]
       public int NearestDc {get; set;}

	}
}
