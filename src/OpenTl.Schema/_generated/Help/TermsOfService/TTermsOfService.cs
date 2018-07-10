// ReSharper disable All

namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x780a0310)]
	public sealed class TTermsOfService : ITermsOfService
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Popup {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.IDataJSON Id {get; set;}

       /// <summary>Binary representation for the 'Text' property</summary>
       [SerializationOrder(3)]
       public byte[] TextAsBinary { get => _TextAsBinary; set { _Text = Encoding.UTF8.GetString(value); _TextAsBinary = value; }}
       private byte[] _TextAsBinary;
       private string _Text;
       public string Text { get => _Text; set { TextAsBinary = Encoding.UTF8.GetBytes(value); _Text = value; }}

       [SerializationOrder(4)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IMessageEntity> Entities {get; set;}

       [SerializationOrder(5)]
       [CanSerialize("Flags", 1)]
       public int MinAgeConfirm {get; set;}

	}
}
