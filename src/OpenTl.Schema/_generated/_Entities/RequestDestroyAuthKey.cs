// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xd1435160)]
    public class RequestDestroyAuthKey : IRequest<IDestroyAuthKeyRes>
    {

    }
}
