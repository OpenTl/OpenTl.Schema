// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x6a3f8d65)]
    public class RequestGetAllDrafts : IRequest<IUpdates>
    {

    }
}
