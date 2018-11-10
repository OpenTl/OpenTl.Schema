﻿// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[System.Serializable]
	[Serialize(0x04deb57d)]
	public sealed class TMsgsStateInfo : IObject
	{
       [SerializationOrder(0)]
       public long ReqMsgId {get; set;}

       /// <summary>Binary representation for the 'Info' property</summary>
       [SerializationOrder(1)]
       public byte[] InfoAsBinary { get => _InfoAsBinary; set { _Info = Encoding.UTF8.GetString(value); _InfoAsBinary = value; }}
       private byte[] _InfoAsBinary;
       private string _Info;
       public string Info { get => _Info; set { InfoAsBinary = Encoding.UTF8.GetBytes(value); _Info = value; }}

	}
}
