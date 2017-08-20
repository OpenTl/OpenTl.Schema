﻿// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x7e6260d7)]
	public class TTextConcat : IRichText
	{
       [SerializationOrder(0)]
       public TVector<IRichText> Texts {get; set;}

	}
}
