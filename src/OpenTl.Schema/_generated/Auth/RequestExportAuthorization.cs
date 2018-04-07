// ReSharper disable All

namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe5bfffcd)]
    public sealed class RequestExportAuthorization : IRequest<OpenTl.Schema.Auth.IExportedAuthorization>
    {
       [SerializationOrder(0)]
       public int DcId {get; set;}

    }
}
