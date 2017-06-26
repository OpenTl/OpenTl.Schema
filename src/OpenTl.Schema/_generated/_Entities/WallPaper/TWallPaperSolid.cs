// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x63117f24)]
	public class TWallPaperSolid : IWallPaper
	{
       [SerializationOrder(0)]
       public int Id {get; set;}

       [SerializationOrder(1)]
       public string Title {get; set;}

       [SerializationOrder(2)]
       public int BgColor {get; set;}

       [SerializationOrder(3)]
       public int Color {get; set;}

	}
}
