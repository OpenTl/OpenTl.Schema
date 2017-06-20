using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using OpenTl.Schema.Serialization.Attributes;
using OpenTl.Schema.Serialization.Serializators.Interfaces;

namespace OpenTl.Schema.Serialization
{
    internal static class SerializationMap
    {
        private static readonly Dictionary<uint, TypeInfo> IdToTypeMap;
        private static readonly Dictionary<TypeInfo, uint> TypeToIdMap;
        
        private static readonly Dictionary<TypeInfo, ISerializator> SerializatorsMap = new Dictionary<TypeInfo, ISerializator>();
        
        private static readonly ISerializator[] Serializators;

        
        static SerializationMap()
        {
            var allTypes = typeof(SerializationMap).GetTypeInfo().Assembly.DefinedTypes.ToArray();
            
            var modelTypes = allTypes
                .Where(t => t.GetCustomAttribute<SerializeAttribute>() != null)
                .ToArray();

            IdToTypeMap = modelTypes.ToDictionary(t => t.GetCustomAttribute<SerializeAttribute>().TypeId);
            TypeToIdMap = modelTypes.ToDictionary(t => t, t => t.GetCustomAttribute<SerializeAttribute>().TypeId);
            
            
            Serializators = allTypes
                .Where(typeof(ISerializator).GetTypeInfo().IsAssignableFrom)
                .Select(ti => Activator.CreateInstance(ti.AsType()))
                .Cast<ISerializator>()
                .ToArray();
            
        }

        internal static bool GetTypeById(uint typeId, out TypeInfo type)
        {
            return IdToTypeMap.TryGetValue(typeId, out type);
        }

        internal static bool GetIdByType(TypeInfo type, out uint typeId)
        {
            return TypeToIdMap.TryGetValue(type, out typeId);
        }
        
        internal static ISerializator GetSerializator(TypeInfo type)
        {
            if (SerializatorsMap.TryGetValue(type, out var serializator))
            {
                return serializator;
            }
            serializator = Serializators.SingleOrDefault(s => s.SupportedType.IsAssignableFrom(type));

            if (serializator == null)
            {
                throw new NotSupportedException($"Can serialize \\ deserialize type: {type}");
            }
                
            return SerializatorsMap[type] = serializator;
        }
        
    }
}