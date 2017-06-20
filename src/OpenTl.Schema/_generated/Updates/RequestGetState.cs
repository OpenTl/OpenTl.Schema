namespace OpenTl.Schema.Updates
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xedd4882a)]
    public class RequestGetState : IRequest<Updates.IState>
    {

    }
}
