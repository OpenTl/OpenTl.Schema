// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2e13f4c3)]
	public sealed class TUser : IUser
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 10)]
       public bool Self {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 11)]
       public bool Contact {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 12)]
       public bool MutualContact {get; set;}

       [SerializationOrder(4)]
       [FromFlag("Flags", 13)]
       public bool Deleted {get; set;}

       [SerializationOrder(5)]
       [FromFlag("Flags", 14)]
       public bool Bot {get; set;}

       [SerializationOrder(6)]
       [FromFlag("Flags", 15)]
       public bool BotChatHistory {get; set;}

       [SerializationOrder(7)]
       [FromFlag("Flags", 16)]
       public bool BotNochats {get; set;}

       [SerializationOrder(8)]
       [FromFlag("Flags", 17)]
       public bool Verified {get; set;}

       [SerializationOrder(9)]
       [FromFlag("Flags", 18)]
       public bool Restricted {get; set;}

       [SerializationOrder(10)]
       [FromFlag("Flags", 20)]
       public bool Min {get; set;}

       [SerializationOrder(11)]
       [FromFlag("Flags", 21)]
       public bool BotInlineGeo {get; set;}

       [SerializationOrder(12)]
       public int Id {get; set;}

       [SerializationOrder(13)]
       [CanSerialize("Flags", 0)]
       public long AccessHash {get; set;}

       /// <summary>Binary representation for the 'FirstName' property</summary>
       [SerializationOrder(14)]
       [CanSerialize("Flags", 1)]
       public byte[] FirstNameAsBinary { get => _FirstNameAsBinary; set { _FirstName = Encoding.UTF8.GetString(value); _FirstNameAsBinary = value; }}
       private byte[] _FirstNameAsBinary;
       private string _FirstName;
       public string FirstName { get => _FirstName; set { FirstNameAsBinary = Encoding.UTF8.GetBytes(value); _FirstName = value; }}

       /// <summary>Binary representation for the 'LastName' property</summary>
       [SerializationOrder(15)]
       [CanSerialize("Flags", 2)]
       public byte[] LastNameAsBinary { get => _LastNameAsBinary; set { _LastName = Encoding.UTF8.GetString(value); _LastNameAsBinary = value; }}
       private byte[] _LastNameAsBinary;
       private string _LastName;
       public string LastName { get => _LastName; set { LastNameAsBinary = Encoding.UTF8.GetBytes(value); _LastName = value; }}

       /// <summary>Binary representation for the 'Username' property</summary>
       [SerializationOrder(16)]
       [CanSerialize("Flags", 3)]
       public byte[] UsernameAsBinary { get => _UsernameAsBinary; set { _Username = Encoding.UTF8.GetString(value); _UsernameAsBinary = value; }}
       private byte[] _UsernameAsBinary;
       private string _Username;
       public string Username { get => _Username; set { UsernameAsBinary = Encoding.UTF8.GetBytes(value); _Username = value; }}

       /// <summary>Binary representation for the 'Phone' property</summary>
       [SerializationOrder(17)]
       [CanSerialize("Flags", 4)]
       public byte[] PhoneAsBinary { get => _PhoneAsBinary; set { _Phone = Encoding.UTF8.GetString(value); _PhoneAsBinary = value; }}
       private byte[] _PhoneAsBinary;
       private string _Phone;
       public string Phone { get => _Phone; set { PhoneAsBinary = Encoding.UTF8.GetBytes(value); _Phone = value; }}

       [SerializationOrder(18)]
       [CanSerialize("Flags", 5)]
       public OpenTl.Schema.IUserProfilePhoto Photo {get; set;}

       [SerializationOrder(19)]
       [CanSerialize("Flags", 6)]
       public OpenTl.Schema.IUserStatus Status {get; set;}

       [SerializationOrder(20)]
       [CanSerialize("Flags", 14)]
       public int BotInfoVersion {get; set;}

       /// <summary>Binary representation for the 'RestrictionReason' property</summary>
       [SerializationOrder(21)]
       [CanSerialize("Flags", 18)]
       public byte[] RestrictionReasonAsBinary { get => _RestrictionReasonAsBinary; set { _RestrictionReason = Encoding.UTF8.GetString(value); _RestrictionReasonAsBinary = value; }}
       private byte[] _RestrictionReasonAsBinary;
       private string _RestrictionReason;
       public string RestrictionReason { get => _RestrictionReason; set { RestrictionReasonAsBinary = Encoding.UTF8.GetBytes(value); _RestrictionReason = value; }}

       /// <summary>Binary representation for the 'BotInlinePlaceholder' property</summary>
       [SerializationOrder(22)]
       [CanSerialize("Flags", 19)]
       public byte[] BotInlinePlaceholderAsBinary { get => _BotInlinePlaceholderAsBinary; set { _BotInlinePlaceholder = Encoding.UTF8.GetString(value); _BotInlinePlaceholderAsBinary = value; }}
       private byte[] _BotInlinePlaceholderAsBinary;
       private string _BotInlinePlaceholder;
       public string BotInlinePlaceholder { get => _BotInlinePlaceholder; set { BotInlinePlaceholderAsBinary = Encoding.UTF8.GetBytes(value); _BotInlinePlaceholder = value; }}

       /// <summary>Binary representation for the 'LangCode' property</summary>
       [SerializationOrder(23)]
       [CanSerialize("Flags", 22)]
       public byte[] LangCodeAsBinary { get => _LangCodeAsBinary; set { _LangCode = Encoding.UTF8.GetString(value); _LangCodeAsBinary = value; }}
       private byte[] _LangCodeAsBinary;
       private string _LangCode;
       public string LangCode { get => _LangCode; set { LangCodeAsBinary = Encoding.UTF8.GetBytes(value); _LangCode = value; }}

	}
}
