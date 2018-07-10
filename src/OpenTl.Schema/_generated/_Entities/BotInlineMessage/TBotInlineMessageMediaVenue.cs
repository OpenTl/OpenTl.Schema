// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x8a86659c)]
	public sealed class TBotInlineMessageMediaVenue : IBotInlineMessage
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IGeoPoint Geo {get; set;}

       /// <summary>Binary representation for the 'Title' property</summary>
       [SerializationOrder(2)]
       public byte[] TitleAsBinary { get => _TitleAsBinary; set { _Title = Encoding.UTF8.GetString(value); _TitleAsBinary = value; }}
       private byte[] _TitleAsBinary;
       private string _Title;
       public string Title { get => _Title; set { TitleAsBinary = Encoding.UTF8.GetBytes(value); _Title = value; }}

       /// <summary>Binary representation for the 'Address' property</summary>
       [SerializationOrder(3)]
       public byte[] AddressAsBinary { get => _AddressAsBinary; set { _Address = Encoding.UTF8.GetString(value); _AddressAsBinary = value; }}
       private byte[] _AddressAsBinary;
       private string _Address;
       public string Address { get => _Address; set { AddressAsBinary = Encoding.UTF8.GetBytes(value); _Address = value; }}

       /// <summary>Binary representation for the 'Provider' property</summary>
       [SerializationOrder(4)]
       public byte[] ProviderAsBinary { get => _ProviderAsBinary; set { _Provider = Encoding.UTF8.GetString(value); _ProviderAsBinary = value; }}
       private byte[] _ProviderAsBinary;
       private string _Provider;
       public string Provider { get => _Provider; set { ProviderAsBinary = Encoding.UTF8.GetBytes(value); _Provider = value; }}

       /// <summary>Binary representation for the 'VenueId' property</summary>
       [SerializationOrder(5)]
       public byte[] VenueIdAsBinary { get => _VenueIdAsBinary; set { _VenueId = Encoding.UTF8.GetString(value); _VenueIdAsBinary = value; }}
       private byte[] _VenueIdAsBinary;
       private string _VenueId;
       public string VenueId { get => _VenueId; set { VenueIdAsBinary = Encoding.UTF8.GetBytes(value); _VenueId = value; }}

       /// <summary>Binary representation for the 'VenueType' property</summary>
       [SerializationOrder(6)]
       public byte[] VenueTypeAsBinary { get => _VenueTypeAsBinary; set { _VenueType = Encoding.UTF8.GetString(value); _VenueTypeAsBinary = value; }}
       private byte[] _VenueTypeAsBinary;
       private string _VenueType;
       public string VenueType { get => _VenueType; set { VenueTypeAsBinary = Encoding.UTF8.GetBytes(value); _VenueType = value; }}

       [SerializationOrder(7)]
       [CanSerialize("Flags", 2)]
       public OpenTl.Schema.IReplyMarkup ReplyMarkup {get; set;}

	}
}
