﻿// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2979eeb2)]
	public class TLangPackStringDeleted : ILangPackString
	{
       [SerializationOrder(0)]
       public string Key {get; set;}

	}
}