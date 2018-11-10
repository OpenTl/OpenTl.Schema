﻿// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[System.Serializable]
	[Serialize(0x63117f24)]
	public sealed class TWallPaperSolid : IWallPaper
	{
       [SerializationOrder(0)]
       public int Id {get; set;}

       /// <summary>Binary representation for the 'Title' property</summary>
       [SerializationOrder(1)]
       public byte[] TitleAsBinary { get => _TitleAsBinary; set { _Title = Encoding.UTF8.GetString(value); _TitleAsBinary = value; }}
       private byte[] _TitleAsBinary;
       private string _Title;
       public string Title { get => _Title; set { TitleAsBinary = Encoding.UTF8.GetBytes(value); _Title = value; }}

       [SerializationOrder(2)]
       public int BgColor {get; set;}

       [SerializationOrder(3)]
       public int Color {get; set;}

	}
}
