// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x4222fa74)]
    public class RequestGetMessages : IRequest<OpenTl.Schema.Messages.IMessages>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.TVector<int> Id {get; set;}

    }
}
