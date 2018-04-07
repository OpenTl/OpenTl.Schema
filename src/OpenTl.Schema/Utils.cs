namespace OpenTl.Schema
{
    public static class Utils
    {
        public static T As<T>(this IObject obj) where T: class, IObject
        {
            return obj as T;
        }
        
        public static T Is<T>(this IObject obj) where T: IObject
        {
            return (T)obj;
        }
        
        public static bool IsEmpty(this IObject obj)
        {
            return obj is IEmpty;
        }
    }
}