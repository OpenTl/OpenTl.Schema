// ReSharper disable All

namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3dc0f114)]
    public sealed class RequestGetRecentMeUrls : IRequest<OpenTl.Schema.Help.IRecentMeUrls>
    {
       /// <summary>Binary representation for the 'Referer' property</summary>
       [SerializationOrder(0)]
       public byte[] RefererAsBinary { get => _RefererAsBinary; set { _Referer = Encoding.UTF8.GetString(value); _RefererAsBinary = value; }}
       private byte[] _RefererAsBinary;
       private string _Referer;
       public string Referer { get => _Referer; set { RefererAsBinary = Encoding.UTF8.GetBytes(value); _Referer = value; }}

    }
}
