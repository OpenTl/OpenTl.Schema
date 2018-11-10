﻿// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[System.Serializable]
	[Serialize(0xda13538a)]
	public sealed class TChatParticipantCreator : IChatParticipant
	{
       [SerializationOrder(0)]
       public int UserId {get; set;}

	}
}
