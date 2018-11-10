﻿// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[System.Serializable]
	[Serialize(0x8e3f9ebe)]
	public sealed class TPagePart : IPage
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IPageBlock> Blocks {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IPhoto> Photos {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IDocument> Documents {get; set;}

	}
}
