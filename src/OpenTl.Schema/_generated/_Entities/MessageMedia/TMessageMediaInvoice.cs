// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x84551347)]
	public sealed class TMessageMediaInvoice : IMessageMedia
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 1)]
       public bool ShippingAddressRequested {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 3)]
       public bool Test {get; set;}

       /// <summary>Binary representation for the 'Title' property</summary>
       [SerializationOrder(3)]
       public byte[] TitleAsBinary { get => _TitleAsBinary; set { _Title = Encoding.UTF8.GetString(value); _TitleAsBinary = value; }}
       private byte[] _TitleAsBinary;
       private string _Title;
       public string Title { get => _Title; set { TitleAsBinary = Encoding.UTF8.GetBytes(value); _Title = value; }}

       /// <summary>Binary representation for the 'Description' property</summary>
       [SerializationOrder(4)]
       public byte[] DescriptionAsBinary { get => _DescriptionAsBinary; set { _Description = Encoding.UTF8.GetString(value); _DescriptionAsBinary = value; }}
       private byte[] _DescriptionAsBinary;
       private string _Description;
       public string Description { get => _Description; set { DescriptionAsBinary = Encoding.UTF8.GetBytes(value); _Description = value; }}

       [SerializationOrder(5)]
       [CanSerialize("Flags", 0)]
       public OpenTl.Schema.IWebDocument Photo {get; set;}

       [SerializationOrder(6)]
       [CanSerialize("Flags", 2)]
       public int ReceiptMsgId {get; set;}

       /// <summary>Binary representation for the 'Currency' property</summary>
       [SerializationOrder(7)]
       public byte[] CurrencyAsBinary { get => _CurrencyAsBinary; set { _Currency = Encoding.UTF8.GetString(value); _CurrencyAsBinary = value; }}
       private byte[] _CurrencyAsBinary;
       private string _Currency;
       public string Currency { get => _Currency; set { CurrencyAsBinary = Encoding.UTF8.GetBytes(value); _Currency = value; }}

       [SerializationOrder(8)]
       public long TotalAmount {get; set;}

       /// <summary>Binary representation for the 'StartParam' property</summary>
       [SerializationOrder(9)]
       public byte[] StartParamAsBinary { get => _StartParamAsBinary; set { _StartParam = Encoding.UTF8.GetString(value); _StartParamAsBinary = value; }}
       private byte[] _StartParamAsBinary;
       private string _StartParam;
       public string StartParam { get => _StartParam; set { StartParamAsBinary = Encoding.UTF8.GetBytes(value); _StartParam = value; }}

	}
}
