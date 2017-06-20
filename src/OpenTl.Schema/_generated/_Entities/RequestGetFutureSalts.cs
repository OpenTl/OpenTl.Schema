namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb921bd04)]
    public class RequestGetFutureSalts : IRequest<IFutureSalts>
    {
       [SerializationOrder(0)]
       public int Num {get; set;}

    }
}
