// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2144ca19)]
	public sealed class TRpcError : IObject
	{
       [SerializationOrder(0)]
       public int ErrorCode {get; set;}

       /// <summary>Binary representation for the 'ErrorMessage' property</summary>
       [SerializationOrder(1)]
       public byte[] ErrorMessageAsBinary { get => _ErrorMessageAsBinary; set { _ErrorMessage = Encoding.UTF8.GetString(value); _ErrorMessageAsBinary = value; }}
       private byte[] _ErrorMessageAsBinary;
       private string _ErrorMessage;
       public string ErrorMessage { get => _ErrorMessage; set { ErrorMessageAsBinary = Encoding.UTF8.GetBytes(value); _ErrorMessage = value; }}

	}
}
