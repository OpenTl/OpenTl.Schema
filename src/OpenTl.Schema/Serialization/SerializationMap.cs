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
                .Where(t => t.GetCustomAttribute<SerializeAttribute>() != null && typeof(IObject).GetTypeInfo().IsAssignableFrom(t))
                .ToArray();

            IdToTypeMap = modelTypes.ToDictionary(t => t.GetCustomAttribute<SerializeAttribute>().Id);
            TypeToIdMap = modelTypes.ToDictionary(t => t, t => t.GetCustomAttribute<SerializeAttribute>().Id);

            Serializators = allTypes
                .Where(t => typeof(ISerializator).GetTypeInfo().IsAssignableFrom(t) && t.IsClass)
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
            if (type.IsGenericType)
            {
                type = type.GetGenericTypeDefinition().GetTypeInfo();
            }

            return TypeToIdMap.TryGetValue(type, out typeId);
        }

        internal static ISerializator GetSerializator(TypeInfo type)
        {
            ISerializator serializator;
            if (!TryGetSerializator(type, out serializator))
            {
                throw new NotSupportedException($"Can serialize \\ deserialize type: {type}");
            }

            return serializator;
        }

        internal static bool TryGetSerializator(TypeInfo type, out ISerializator serializator)
        {
            if (type.IsGenericType)
            {
                type = type.GetGenericTypeDefinition().GetTypeInfo();
            }

            if (type == typeof(object).GetTypeInfo())
            {
                type = typeof(IObject).GetTypeInfo();
            }

            if (SerializatorsMap.TryGetValue(type, out var foundSerializator))
            {
                serializator = foundSerializator;

                return true;
            }

            serializator = Serializators.SingleOrDefault(s => s.SupportedType.IsAssignableFrom(type));

            if (serializator != null)
            {
                SerializatorsMap[type] = serializator;
                return true;
            }

            return false;
        }
    }
}