// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xae636f24)]
	public class TDisabledFeature : IDisabledFeature
	{
       /// <summary>Binary representation for the 'Feature' property</summary>
       [SerializationOrder(0)]
       public byte[] FeatureAsBinary { get => _FeatureAsBinary; set { _Feature = Encoding.UTF8.GetString(value); _FeatureAsBinary = value; }}
       private byte[] _FeatureAsBinary;
       private string _Feature;
       public string Feature { get => _Feature; set { FeatureAsBinary = Encoding.UTF8.GetBytes(value); _Feature = value; }}

       /// <summary>Binary representation for the 'Description' property</summary>
       [SerializationOrder(1)]
       public byte[] DescriptionAsBinary { get => _DescriptionAsBinary; set { _Description = Encoding.UTF8.GetString(value); _DescriptionAsBinary = value; }}
       private byte[] _DescriptionAsBinary;
       private string _Description;
       public string Description { get => _Description; set { DescriptionAsBinary = Encoding.UTF8.GetBytes(value); _Description = value; }}

	}
}
