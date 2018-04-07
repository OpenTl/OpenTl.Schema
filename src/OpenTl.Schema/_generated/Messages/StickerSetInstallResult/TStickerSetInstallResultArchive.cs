// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x35e410a8)]
	public sealed class TStickerSetInstallResultArchive : IStickerSetInstallResult
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IStickerSetCovered> Sets {get; set;}

	}
}
