// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x7912b71f)]
	public class TMessageMediaVenue : IMessageMedia
	{
       [SerializationOrder(0)]
       public IGeoPoint Geo {get; set;}

       [SerializationOrder(1)]
       public byte[] TitleAsBinary { get => _TitleAsBinary; set { _Title = Encoding.UTF8.GetString(value); _TitleAsBinary = value; }}
       private byte[] _TitleAsBinary;
       private string _Title;
       public string Title { get => _Title; set { TitleAsBinary = Encoding.UTF8.GetBytes(value); _Title = value; }}

       [SerializationOrder(2)]
       public byte[] AddressAsBinary { get => _AddressAsBinary; set { _Address = Encoding.UTF8.GetString(value); _AddressAsBinary = value; }}
       private byte[] _AddressAsBinary;
       private string _Address;
       public string Address { get => _Address; set { AddressAsBinary = Encoding.UTF8.GetBytes(value); _Address = value; }}

       [SerializationOrder(3)]
       public byte[] ProviderAsBinary { get => _ProviderAsBinary; set { _Provider = Encoding.UTF8.GetString(value); _ProviderAsBinary = value; }}
       private byte[] _ProviderAsBinary;
       private string _Provider;
       public string Provider { get => _Provider; set { ProviderAsBinary = Encoding.UTF8.GetBytes(value); _Provider = value; }}

       [SerializationOrder(4)]
       public byte[] VenueIdAsBinary { get => _VenueIdAsBinary; set { _VenueId = Encoding.UTF8.GetString(value); _VenueIdAsBinary = value; }}
       private byte[] _VenueIdAsBinary;
       private string _VenueId;
       public string VenueId { get => _VenueId; set { VenueIdAsBinary = Encoding.UTF8.GetBytes(value); _VenueId = value; }}

	}
}
