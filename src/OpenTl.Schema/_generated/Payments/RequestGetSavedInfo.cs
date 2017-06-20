namespace OpenTl.Schema.Payments
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x227d824b)]
    public class RequestGetSavedInfo : IRequest<Payments.ISavedInfo>
    {

    }
}
