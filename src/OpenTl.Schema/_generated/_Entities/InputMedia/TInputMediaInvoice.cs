// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf4e096c3)]
	public sealed class TInputMediaInvoice : IInputMedia
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       /// <summary>Binary representation for the 'Title' property</summary>
       [SerializationOrder(1)]
       public byte[] TitleAsBinary { get => _TitleAsBinary; set { _Title = Encoding.UTF8.GetString(value); _TitleAsBinary = value; }}
       private byte[] _TitleAsBinary;
       private string _Title;
       public string Title { get => _Title; set { TitleAsBinary = Encoding.UTF8.GetBytes(value); _Title = value; }}

       /// <summary>Binary representation for the 'Description' property</summary>
       [SerializationOrder(2)]
       public byte[] DescriptionAsBinary { get => _DescriptionAsBinary; set { _Description = Encoding.UTF8.GetString(value); _DescriptionAsBinary = value; }}
       private byte[] _DescriptionAsBinary;
       private string _Description;
       public string Description { get => _Description; set { DescriptionAsBinary = Encoding.UTF8.GetBytes(value); _Description = value; }}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 0)]
       public OpenTl.Schema.IInputWebDocument Photo {get; set;}

       [SerializationOrder(4)]
       public OpenTl.Schema.IInvoice Invoice {get; set;}

       [SerializationOrder(5)]
       public byte[] Payload {get; set;}

       /// <summary>Binary representation for the 'Provider' property</summary>
       [SerializationOrder(6)]
       public byte[] ProviderAsBinary { get => _ProviderAsBinary; set { _Provider = Encoding.UTF8.GetString(value); _ProviderAsBinary = value; }}
       private byte[] _ProviderAsBinary;
       private string _Provider;
       public string Provider { get => _Provider; set { ProviderAsBinary = Encoding.UTF8.GetBytes(value); _Provider = value; }}

       [SerializationOrder(7)]
       public OpenTl.Schema.IDataJSON ProviderData {get; set;}

       /// <summary>Binary representation for the 'StartParam' property</summary>
       [SerializationOrder(8)]
       public byte[] StartParamAsBinary { get => _StartParamAsBinary; set { _StartParam = Encoding.UTF8.GetString(value); _StartParamAsBinary = value; }}
       private byte[] _StartParamAsBinary;
       private string _StartParam;
       public string StartParam { get => _StartParam; set { StartParamAsBinary = Encoding.UTF8.GetBytes(value); _StartParam = value; }}

	}
}
