﻿// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xbfd064ec)]
	public class TPageBlockHeader : IPageBlock
	{
       [SerializationOrder(0)]
       public IRichText Text {get; set;}

	}
}
