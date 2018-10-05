// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface ISecureValue : IObject
    {
       BitArray Flags {get; set;}

       OpenTl.Schema.ISecureValueType Type {get; set;}

       OpenTl.Schema.ISecureData Data {get; set;}

       OpenTl.Schema.ISecureFile FrontSide {get; set;}

       OpenTl.Schema.ISecureFile ReverseSide {get; set;}

       OpenTl.Schema.ISecureFile Selfie {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.ISecureFile> Translation {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.ISecureFile> Files {get; set;}

       OpenTl.Schema.ISecurePlainData PlainData {get; set;}

       byte[] Hash {get; set;}

    }
}
