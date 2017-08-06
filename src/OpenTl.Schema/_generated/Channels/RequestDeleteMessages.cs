// ReSharper disable All

namespace OpenTl.Schema.Channels
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x84c1fd4e)]
    public class RequestDeleteMessages : IRequest<Messages.IAffectedMessages>
    {
       [SerializationOrder(0)]
       public IInputChannel Channel {get; set;}

       [SerializationOrder(1)]
       public TVector<int> Id {get; set;}

    }
}
