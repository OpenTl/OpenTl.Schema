// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xeb5ea206)]
    public sealed class RequestSetInlineBotResults : IRequest<bool>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Gallery {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool Private {get; set;}

       [SerializationOrder(3)]
       public long QueryId {get; set;}

       [SerializationOrder(4)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IInputBotInlineResult> Results {get; set;}

       [SerializationOrder(5)]
       public int CacheTime {get; set;}

       /// <summary>Binary representation for the 'NextOffset' property</summary>
       [SerializationOrder(6)]
       [CanSerialize("Flags", 2)]
       public byte[] NextOffsetAsBinary { get => _NextOffsetAsBinary; set { _NextOffset = Encoding.UTF8.GetString(value); _NextOffsetAsBinary = value; }}
       private byte[] _NextOffsetAsBinary;
       private string _NextOffset;
       public string NextOffset { get => _NextOffset; set { NextOffsetAsBinary = Encoding.UTF8.GetBytes(value); _NextOffset = value; }}

       [SerializationOrder(7)]
       [CanSerialize("Flags", 3)]
       public OpenTl.Schema.IInlineBotSwitchPM SwitchPm {get; set;}

    }
}
