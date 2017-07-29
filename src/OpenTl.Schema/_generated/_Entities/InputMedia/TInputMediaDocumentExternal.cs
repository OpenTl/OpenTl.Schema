﻿// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb6f74335)]
	public class TInputMediaDocumentExternal : IInputMedia
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public string Url {get; set;}

       [SerializationOrder(2)]
       public string Caption {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 0)]
       public int TtlSeconds {get; set;}

	}
}
