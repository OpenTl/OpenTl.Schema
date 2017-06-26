// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xaa0cd9e4)]
	public class TSendMessageUploadDocumentAction : ISendMessageAction
	{
       [SerializationOrder(0)]
       public int Progress {get; set;}

	}
}
