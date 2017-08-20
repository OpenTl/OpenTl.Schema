﻿// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x8ffa9a1f)]
	public class TPageBlockSubtitle : IPageBlock
	{
       [SerializationOrder(0)]
       public IRichText Text {get; set;}

	}
}
