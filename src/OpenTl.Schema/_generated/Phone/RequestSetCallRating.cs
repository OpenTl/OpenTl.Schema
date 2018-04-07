// ReSharper disable All

namespace OpenTl.Schema.Phone
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x1c536a34)]
    public sealed class RequestSetCallRating : IRequest<OpenTl.Schema.IUpdates>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputPhoneCall Peer {get; set;}

       [SerializationOrder(1)]
       public int Rating {get; set;}

       /// <summary>Binary representation for the 'Comment' property</summary>
       [SerializationOrder(2)]
       public byte[] CommentAsBinary { get => _CommentAsBinary; set { _Comment = Encoding.UTF8.GetString(value); _CommentAsBinary = value; }}
       private byte[] _CommentAsBinary;
       private string _Comment;
       public string Comment { get => _Comment; set { CommentAsBinary = Encoding.UTF8.GetBytes(value); _Comment = value; }}

    }
}
