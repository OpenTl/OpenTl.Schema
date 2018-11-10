﻿// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[System.Serializable]
	[Serialize(0xd5676710)]
	public sealed class TChannelAdminLogEventActionParticipantToggleAdmin : IChannelAdminLogEventAction
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IChannelParticipant PrevParticipant {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IChannelParticipant NewParticipant {get; set;}

	}
}
