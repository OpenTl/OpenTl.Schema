// ReSharper disable All

namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3fedc75f)]
    public sealed class RequestGetDeepLinkInfo : IRequest<OpenTl.Schema.Help.IDeepLinkInfo>
    {
       /// <summary>Binary representation for the 'Path' property</summary>
       [SerializationOrder(0)]
       public byte[] PathAsBinary { get => _PathAsBinary; set { _Path = Encoding.UTF8.GetString(value); _PathAsBinary = value; }}
       private byte[] _PathAsBinary;
       private string _Path;
       public string Path { get => _Path; set { PathAsBinary = Encoding.UTF8.GetBytes(value); _Path = value; }}

    }
}
