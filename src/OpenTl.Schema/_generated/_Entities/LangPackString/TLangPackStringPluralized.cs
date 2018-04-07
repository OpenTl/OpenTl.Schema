// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x6c47ac9f)]
	public sealed class TLangPackStringPluralized : ILangPackString
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       /// <summary>Binary representation for the 'Key' property</summary>
       [SerializationOrder(1)]
       public byte[] KeyAsBinary { get => _KeyAsBinary; set { _Key = Encoding.UTF8.GetString(value); _KeyAsBinary = value; }}
       private byte[] _KeyAsBinary;
       private string _Key;
       public string Key { get => _Key; set { KeyAsBinary = Encoding.UTF8.GetBytes(value); _Key = value; }}

       /// <summary>Binary representation for the 'ZeroValue' property</summary>
       [SerializationOrder(2)]
       [CanSerialize("Flags", 0)]
       public byte[] ZeroValueAsBinary { get => _ZeroValueAsBinary; set { _ZeroValue = Encoding.UTF8.GetString(value); _ZeroValueAsBinary = value; }}
       private byte[] _ZeroValueAsBinary;
       private string _ZeroValue;
       public string ZeroValue { get => _ZeroValue; set { ZeroValueAsBinary = Encoding.UTF8.GetBytes(value); _ZeroValue = value; }}

       /// <summary>Binary representation for the 'OneValue' property</summary>
       [SerializationOrder(3)]
       [CanSerialize("Flags", 1)]
       public byte[] OneValueAsBinary { get => _OneValueAsBinary; set { _OneValue = Encoding.UTF8.GetString(value); _OneValueAsBinary = value; }}
       private byte[] _OneValueAsBinary;
       private string _OneValue;
       public string OneValue { get => _OneValue; set { OneValueAsBinary = Encoding.UTF8.GetBytes(value); _OneValue = value; }}

       /// <summary>Binary representation for the 'TwoValue' property</summary>
       [SerializationOrder(4)]
       [CanSerialize("Flags", 2)]
       public byte[] TwoValueAsBinary { get => _TwoValueAsBinary; set { _TwoValue = Encoding.UTF8.GetString(value); _TwoValueAsBinary = value; }}
       private byte[] _TwoValueAsBinary;
       private string _TwoValue;
       public string TwoValue { get => _TwoValue; set { TwoValueAsBinary = Encoding.UTF8.GetBytes(value); _TwoValue = value; }}

       /// <summary>Binary representation for the 'FewValue' property</summary>
       [SerializationOrder(5)]
       [CanSerialize("Flags", 3)]
       public byte[] FewValueAsBinary { get => _FewValueAsBinary; set { _FewValue = Encoding.UTF8.GetString(value); _FewValueAsBinary = value; }}
       private byte[] _FewValueAsBinary;
       private string _FewValue;
       public string FewValue { get => _FewValue; set { FewValueAsBinary = Encoding.UTF8.GetBytes(value); _FewValue = value; }}

       /// <summary>Binary representation for the 'ManyValue' property</summary>
       [SerializationOrder(6)]
       [CanSerialize("Flags", 4)]
       public byte[] ManyValueAsBinary { get => _ManyValueAsBinary; set { _ManyValue = Encoding.UTF8.GetString(value); _ManyValueAsBinary = value; }}
       private byte[] _ManyValueAsBinary;
       private string _ManyValue;
       public string ManyValue { get => _ManyValue; set { ManyValueAsBinary = Encoding.UTF8.GetBytes(value); _ManyValue = value; }}

       /// <summary>Binary representation for the 'OtherValue' property</summary>
       [SerializationOrder(7)]
       public byte[] OtherValueAsBinary { get => _OtherValueAsBinary; set { _OtherValue = Encoding.UTF8.GetString(value); _OtherValueAsBinary = value; }}
       private byte[] _OtherValueAsBinary;
       private string _OtherValue;
       public string OtherValue { get => _OtherValue; set { OtherValueAsBinary = Encoding.UTF8.GetBytes(value); _OtherValue = value; }}

	}
}
