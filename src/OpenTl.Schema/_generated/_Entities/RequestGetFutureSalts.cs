// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb921bd04)]
    public sealed class RequestGetFutureSalts : IRequest<OpenTl.Schema.IFutureSalts>
    {
       [SerializationOrder(0)]
       public int Num {get; set;}

    }
}
