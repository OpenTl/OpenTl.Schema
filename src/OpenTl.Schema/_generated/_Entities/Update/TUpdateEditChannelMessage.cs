﻿// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[System.Serializable]
	[Serialize(0x1b3f4df7)]
	public sealed class TUpdateEditChannelMessage : IUpdate
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IMessage Message {get; set;}

       [SerializationOrder(1)]
       public int Pts {get; set;}

       [SerializationOrder(2)]
       public int PtsCount {get; set;}

	}
}
