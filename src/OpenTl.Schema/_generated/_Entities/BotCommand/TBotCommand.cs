// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc27ac8c7)]
	public sealed class TBotCommand : IBotCommand
	{
       /// <summary>Binary representation for the 'Command' property</summary>
       [SerializationOrder(0)]
       public byte[] CommandAsBinary { get => _CommandAsBinary; set { _Command = Encoding.UTF8.GetString(value); _CommandAsBinary = value; }}
       private byte[] _CommandAsBinary;
       private string _Command;
       public string Command { get => _Command; set { CommandAsBinary = Encoding.UTF8.GetBytes(value); _Command = value; }}

       /// <summary>Binary representation for the 'Description' property</summary>
       [SerializationOrder(1)]
       public byte[] DescriptionAsBinary { get => _DescriptionAsBinary; set { _Description = Encoding.UTF8.GetString(value); _DescriptionAsBinary = value; }}
       private byte[] _DescriptionAsBinary;
       private string _Description;
       public string Description { get => _Description; set { DescriptionAsBinary = Encoding.UTF8.GetBytes(value); _Description = value; }}

	}
}
