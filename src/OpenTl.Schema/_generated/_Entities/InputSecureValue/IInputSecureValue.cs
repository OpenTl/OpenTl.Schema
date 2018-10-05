// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IInputSecureValue : IObject
    {
       BitArray Flags {get; set;}

       OpenTl.Schema.ISecureValueType Type {get; set;}

       OpenTl.Schema.ISecureData Data {get; set;}

       OpenTl.Schema.IInputSecureFile FrontSide {get; set;}

       OpenTl.Schema.IInputSecureFile ReverseSide {get; set;}

       OpenTl.Schema.IInputSecureFile Selfie {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IInputSecureFile> Translation {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IInputSecureFile> Files {get; set;}

       OpenTl.Schema.ISecurePlainData PlainData {get; set;}

    }
}
