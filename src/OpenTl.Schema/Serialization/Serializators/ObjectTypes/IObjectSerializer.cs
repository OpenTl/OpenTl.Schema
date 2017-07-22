using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using OpenTl.Schema.Serialization.Serializators.Interfaces;

namespace OpenTl.Schema.Serialization.Serializators.ObjectTypes
 {
     internal class ObjectSerializer : ISerializator
     {
         public TypeInfo SupportedType { get; } = typeof(IObject).GetTypeInfo();
 
         public void Serialize(BinaryWriter writer, object value, SerializationMetadata metadata)
         {
             Serializer.Serialize(value, writer);

             if (IsAssignableToGenericType(value.GetType().GetTypeInfo(), typeof(TVector<>)))
             {
                 var collection = (ICollection) ((dynamic) value).Items ;
                 writer.Write(collection.Count);
            
                 foreach (var item in collection)
                 {
                     Serializer.Serialize(item, writer);
                 }
             }
         }

         public object Deserialize(BinaryReader reader, SerializationMetadata metadata)
         {
             var value =  Serializer.Deserialize(reader, metadata.PropertyTypeInfo);

             if (IsAssignableToGenericType(value.GetType().GetTypeInfo(), typeof(TVector<>)))
             {
                 var length = reader.ReadInt32();
                 var genParameter = metadata.PropertyTypeInfo.GenericTypeArguments[0];
                 var listType = typeof(List<>).MakeGenericType(genParameter);
                 var children = (IList) Activator.CreateInstance(listType);
                 for (var j = 0; j < length; j++)
                 {
                     var child = Serializer.Deserialize(reader, genParameter.GetTypeInfo());
                     children.Add(child);
                 }

                 value.GetType().GetTypeInfo().GetProperty("Items").SetValue(value, children);
             }

             return value;
         }
         
         public static bool IsAssignableToGenericType(TypeInfo givenType, Type genericType)
         {
             var interfaceTypes = givenType.GetInterfaces().Select(it => it.GetTypeInfo());

             if (interfaceTypes.Any(it => it.IsGenericType && it.GetGenericTypeDefinition() == genericType))
             {
                 return true;
             }

             if (givenType.IsGenericType && givenType.GetGenericTypeDefinition() == genericType)
                 return true;

             var baseType = givenType.BaseType;
             return baseType != null && IsAssignableToGenericType(baseType.GetTypeInfo(), genericType);
         }
     }
 }