// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x927c55b4)]
	public sealed class TInputChatUploadedPhoto : IInputChatPhoto
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputFile File {get; set;}

	}
}
