// ReSharper disable All

namespace OpenTl.Schema.Channels
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf4893d7f)]
    public class RequestCreateChannel : IRequest<IUpdates>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Broadcast {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool Megagroup {get; set;}

       [SerializationOrder(3)]
       public byte[] TitleAsBinary { get => _TitleAsBinary; set { _Title = Encoding.UTF8.GetString(value); _TitleAsBinary = value; }}
       private byte[] _TitleAsBinary;
       private string _Title;
       public string Title { get => _Title; set { TitleAsBinary = Encoding.UTF8.GetBytes(value); _Title = value; }}

       [SerializationOrder(4)]
       public byte[] AboutAsBinary { get => _AboutAsBinary; set { _About = Encoding.UTF8.GetString(value); _AboutAsBinary = value; }}
       private byte[] _AboutAsBinary;
       private string _About;
       public string About { get => _About; set { AboutAsBinary = Encoding.UTF8.GetBytes(value); _About = value; }}

    }
}
