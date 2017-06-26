// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x35e410a8)]
	public class TStickerSetInstallResultArchive : IStickerSetInstallResult
	{
       [SerializationOrder(0)]
       public TVector<IStickerSetCovered> Sets {get; set;}

	}
}
