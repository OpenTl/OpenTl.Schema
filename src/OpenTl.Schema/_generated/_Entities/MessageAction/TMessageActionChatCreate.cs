// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xa6638b9a)]
	public class TMessageActionChatCreate : IMessageAction
	{
       [SerializationOrder(0)]
       public byte[] ItleAsBinary { get => _ItleAsBinary; set { _Itle = Encoding.UTF8.GetString(value); _ItleAsBinary = value; }}
       private byte[] _ItleAsBinary;
       private string _Itle;
       public string Itle { get => _Itle; set { ItleAsBinary = Encoding.UTF8.GetBytes(value); _Itle = value; }}

       [SerializationOrder(1)]
       public TVector<int> Users {get; set;}

	}
}
