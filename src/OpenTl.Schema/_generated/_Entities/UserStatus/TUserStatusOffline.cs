// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x8c703f)]
	public sealed class TUserStatusOffline : IUserStatus
	{
       [SerializationOrder(0)]
       public int WasOnline {get; set;}

	}
}
