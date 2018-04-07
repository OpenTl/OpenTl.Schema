// ReSharper disable All

namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x67a3ff2c)]
    public sealed class RequestImportBotAuthorization : IRequest<OpenTl.Schema.Auth.IAuthorization>
    {
       [SerializationOrder(0)]
       public int Flags {get; set;}

       [SerializationOrder(1)]
       public int ApiId {get; set;}

       /// <summary>Binary representation for the 'ApiHash' property</summary>
       [SerializationOrder(2)]
       public byte[] ApiHashAsBinary { get => _ApiHashAsBinary; set { _ApiHash = Encoding.UTF8.GetString(value); _ApiHashAsBinary = value; }}
       private byte[] _ApiHashAsBinary;
       private string _ApiHash;
       public string ApiHash { get => _ApiHash; set { ApiHashAsBinary = Encoding.UTF8.GetBytes(value); _ApiHash = value; }}

       /// <summary>Binary representation for the 'BotAuthToken' property</summary>
       [SerializationOrder(3)]
       public byte[] BotAuthTokenAsBinary { get => _BotAuthTokenAsBinary; set { _BotAuthToken = Encoding.UTF8.GetString(value); _BotAuthTokenAsBinary = value; }}
       private byte[] _BotAuthTokenAsBinary;
       private string _BotAuthToken;
       public string BotAuthToken { get => _BotAuthToken; set { BotAuthTokenAsBinary = Encoding.UTF8.GetBytes(value); _BotAuthToken = value; }}

    }
}
