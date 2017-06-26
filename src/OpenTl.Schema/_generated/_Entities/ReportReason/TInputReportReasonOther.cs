// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe1746d0a)]
	public class TInputReportReasonOther : IReportReason
	{
       [SerializationOrder(0)]
       public string Ext {get; set;}

	}
}
