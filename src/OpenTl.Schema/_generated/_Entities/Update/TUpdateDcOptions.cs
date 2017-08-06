// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x8e5e9873)]
	public class TUpdateDcOptions : IUpdate
	{
       [SerializationOrder(0)]
       public TVector<IDcOption> DcOptions {get; set;}

	}
}
