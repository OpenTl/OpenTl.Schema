// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xaf509d20)]
	public sealed class TPeerNotifySettings : IPeerNotifySettings
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [CanSerialize("Flags", 0)]
       public bool ShowPreviews {get; set;}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 1)]
       public bool Silent {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 2)]
       public int MuteUntil {get; set;}

       /// <summary>Binary representation for the 'Sound' property</summary>
       [SerializationOrder(4)]
       [CanSerialize("Flags", 3)]
       public byte[] SoundAsBinary { get => _SoundAsBinary; set { _Sound = Encoding.UTF8.GetString(value); _SoundAsBinary = value; }}
       private byte[] _SoundAsBinary;
       private string _Sound;
       public string Sound { get => _Sound; set { SoundAsBinary = Encoding.UTF8.GetBytes(value); _Sound = value; }}

	}
}
