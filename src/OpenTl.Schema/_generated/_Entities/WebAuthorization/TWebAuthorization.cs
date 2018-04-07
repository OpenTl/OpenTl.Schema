// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xcac943f2)]
	public sealed class TWebAuthorization : IWebAuthorization
	{
       [SerializationOrder(0)]
       public long Hash {get; set;}

       [SerializationOrder(1)]
       public int BotId {get; set;}

       /// <summary>Binary representation for the 'Domain' property</summary>
       [SerializationOrder(2)]
       public byte[] DomainAsBinary { get => _DomainAsBinary; set { _Domain = Encoding.UTF8.GetString(value); _DomainAsBinary = value; }}
       private byte[] _DomainAsBinary;
       private string _Domain;
       public string Domain { get => _Domain; set { DomainAsBinary = Encoding.UTF8.GetBytes(value); _Domain = value; }}

       /// <summary>Binary representation for the 'Browser' property</summary>
       [SerializationOrder(3)]
       public byte[] BrowserAsBinary { get => _BrowserAsBinary; set { _Browser = Encoding.UTF8.GetString(value); _BrowserAsBinary = value; }}
       private byte[] _BrowserAsBinary;
       private string _Browser;
       public string Browser { get => _Browser; set { BrowserAsBinary = Encoding.UTF8.GetBytes(value); _Browser = value; }}

       /// <summary>Binary representation for the 'Platform' property</summary>
       [SerializationOrder(4)]
       public byte[] PlatformAsBinary { get => _PlatformAsBinary; set { _Platform = Encoding.UTF8.GetString(value); _PlatformAsBinary = value; }}
       private byte[] _PlatformAsBinary;
       private string _Platform;
       public string Platform { get => _Platform; set { PlatformAsBinary = Encoding.UTF8.GetBytes(value); _Platform = value; }}

       [SerializationOrder(5)]
       public int DateCreated {get; set;}

       [SerializationOrder(6)]
       public int DateActive {get; set;}

       /// <summary>Binary representation for the 'Ip' property</summary>
       [SerializationOrder(7)]
       public byte[] IpAsBinary { get => _IpAsBinary; set { _Ip = Encoding.UTF8.GetString(value); _IpAsBinary = value; }}
       private byte[] _IpAsBinary;
       private string _Ip;
       public string Ip { get => _Ip; set { IpAsBinary = Encoding.UTF8.GetBytes(value); _Ip = value; }}

       /// <summary>Binary representation for the 'Region' property</summary>
       [SerializationOrder(8)]
       public byte[] RegionAsBinary { get => _RegionAsBinary; set { _Region = Encoding.UTF8.GetString(value); _RegionAsBinary = value; }}
       private byte[] _RegionAsBinary;
       private string _Region;
       public string Region { get => _Region; set { RegionAsBinary = Encoding.UTF8.GetBytes(value); _Region = value; }}

	}
}
