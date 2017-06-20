namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe5bfffcd)]
    public class RequestExportAuthorization : IRequest<Auth.IExportedAuthorization>
    {
       [SerializationOrder(0)]
       public int DcId {get; set;}

    }
}
