// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xd27ff082)]
	public sealed class TInputCheckPasswordSRP : IInputCheckPasswordSRP
	{
       [SerializationOrder(0)]
       public long SrpId {get; set;}

       [SerializationOrder(1)]
       public byte[] A {get; set;}

       [SerializationOrder(2)]
       public byte[] M1 {get; set;}

	}
}
