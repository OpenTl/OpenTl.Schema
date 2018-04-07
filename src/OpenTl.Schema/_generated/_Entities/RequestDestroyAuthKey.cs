// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xd1435160)]
    public sealed class RequestDestroyAuthKey : IRequest<OpenTl.Schema.IDestroyAuthKeyRes>
    {

    }
}
