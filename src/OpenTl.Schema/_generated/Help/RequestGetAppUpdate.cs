// ReSharper disable All

namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x522d5a7d)]
    public sealed class RequestGetAppUpdate : IRequest<OpenTl.Schema.Help.IAppUpdate>
    {
       /// <summary>Binary representation for the 'Source' property</summary>
       [SerializationOrder(0)]
       public byte[] SourceAsBinary { get => _SourceAsBinary; set { _Source = Encoding.UTF8.GetString(value); _SourceAsBinary = value; }}
       private byte[] _SourceAsBinary;
       private string _Source;
       public string Source { get => _Source; set { SourceAsBinary = Encoding.UTF8.GetBytes(value); _Source = value; }}

    }
}
