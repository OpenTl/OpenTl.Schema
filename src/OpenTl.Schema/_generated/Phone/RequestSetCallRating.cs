// ReSharper disable All

namespace OpenTl.Schema.Phone
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x1c536a34)]
    public class RequestSetCallRating : IRequest<IUpdates>
    {
       [SerializationOrder(0)]
       public IInputPhoneCall Peer {get; set;}

       [SerializationOrder(1)]
       public int Rating {get; set;}

       [SerializationOrder(2)]
       public byte[] CommentAsBinary { get => _CommentAsBinary; set { _Comment = Encoding.UTF8.GetString(value); _CommentAsBinary = value; }}
       private byte[] _CommentAsBinary;
       private string _Comment;
       public string Comment { get => _Comment; set { CommentAsBinary = Encoding.UTF8.GetBytes(value); _Comment = value; }}

    }
}
