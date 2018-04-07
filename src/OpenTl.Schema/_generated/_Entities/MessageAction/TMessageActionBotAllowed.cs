// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xabe9affe)]
	public sealed class TMessageActionBotAllowed : IMessageAction
	{
       /// <summary>Binary representation for the 'Domain' property</summary>
       [SerializationOrder(0)]
       public byte[] DomainAsBinary { get => _DomainAsBinary; set { _Domain = Encoding.UTF8.GetString(value); _DomainAsBinary = value; }}
       private byte[] _DomainAsBinary;
       private string _Domain;
       public string Domain { get => _Domain; set { DomainAsBinary = Encoding.UTF8.GetBytes(value); _Domain = value; }}

	}
}
