// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xfc2e05bc)]
	public sealed class TChatInviteExported : IExportedChatInvite
	{
       /// <summary>Binary representation for the 'Link' property</summary>
       [SerializationOrder(0)]
       public byte[] LinkAsBinary { get => _LinkAsBinary; set { _Link = Encoding.UTF8.GetString(value); _LinkAsBinary = value; }}
       private byte[] _LinkAsBinary;
       private string _Link;
       public string Link { get => _Link; set { LinkAsBinary = Encoding.UTF8.GetBytes(value); _Link = value; }}

	}
}
