// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf351d7ab)]
	public sealed class TSendMessageUploadAudioAction : ISendMessageAction
	{
       [SerializationOrder(0)]
       public int Progress {get; set;}

	}
}
