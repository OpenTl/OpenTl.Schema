// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x6a4afc38)]
	public sealed class TChannelAdminLogEventActionChangeUsername : IChannelAdminLogEventAction
	{
       /// <summary>Binary representation for the 'PrevValue' property</summary>
       [SerializationOrder(0)]
       public byte[] PrevValueAsBinary { get => _PrevValueAsBinary; set { _PrevValue = Encoding.UTF8.GetString(value); _PrevValueAsBinary = value; }}
       private byte[] _PrevValueAsBinary;
       private string _PrevValue;
       public string PrevValue { get => _PrevValue; set { PrevValueAsBinary = Encoding.UTF8.GetBytes(value); _PrevValue = value; }}

       /// <summary>Binary representation for the 'NewValue' property</summary>
       [SerializationOrder(1)]
       public byte[] NewValueAsBinary { get => _NewValueAsBinary; set { _NewValue = Encoding.UTF8.GetString(value); _NewValueAsBinary = value; }}
       private byte[] _NewValueAsBinary;
       private string _NewValue;
       public string NewValue { get => _NewValue; set { NewValueAsBinary = Encoding.UTF8.GetBytes(value); _NewValue = value; }}

	}
}
