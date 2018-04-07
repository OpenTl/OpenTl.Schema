module Models

open System;
open System.Collections.Generic;

type TlAttr = {Name: string; Type: string}

type TlRequest = {Id: string; Method: string; GenericType: string; Attrs: TlAttr list; Type: string }

type TlType = {Id: string; Predicate: string; GenericType: string; Attrs: TlAttr list; Type: string }

type Schema = {Types: List<TlType>; Requests: List<TlRequest>}