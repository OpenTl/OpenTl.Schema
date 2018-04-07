// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x947ca848)]
	public sealed class TBotResults : IBotResults
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Gallery {get; set;}

       [SerializationOrder(2)]
       public long QueryId {get; set;}

       /// <summary>Binary representation for the 'NextOffset' property</summary>
       [SerializationOrder(3)]
       [CanSerialize("Flags", 1)]
       public byte[] NextOffsetAsBinary { get => _NextOffsetAsBinary; set { _NextOffset = Encoding.UTF8.GetString(value); _NextOffsetAsBinary = value; }}
       private byte[] _NextOffsetAsBinary;
       private string _NextOffset;
       public string NextOffset { get => _NextOffset; set { NextOffsetAsBinary = Encoding.UTF8.GetBytes(value); _NextOffset = value; }}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 2)]
       public OpenTl.Schema.IInlineBotSwitchPM SwitchPm {get; set;}

       [SerializationOrder(5)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IBotInlineResult> Results {get; set;}

       [SerializationOrder(6)]
       public int CacheTime {get; set;}

       [SerializationOrder(7)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IUser> Users {get; set;}

	}
}
