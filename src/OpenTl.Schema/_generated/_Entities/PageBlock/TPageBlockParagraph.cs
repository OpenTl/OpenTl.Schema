// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x467a0766)]
	public class TPageBlockParagraph : IPageBlock
	{
       [SerializationOrder(0)]
       public IRichText Text {get; set;}

	}
}
