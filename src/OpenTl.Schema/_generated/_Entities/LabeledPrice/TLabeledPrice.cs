// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xcb296bf8)]
	public sealed class TLabeledPrice : ILabeledPrice
	{
       /// <summary>Binary representation for the 'Label' property</summary>
       [SerializationOrder(0)]
       public byte[] LabelAsBinary { get => _LabelAsBinary; set { _Label = Encoding.UTF8.GetString(value); _LabelAsBinary = value; }}
       private byte[] _LabelAsBinary;
       private string _Label;
       public string Label { get => _Label; set { LabelAsBinary = Encoding.UTF8.GetBytes(value); _Label = value; }}

       [SerializationOrder(1)]
       public long Amount {get; set;}

	}
}
