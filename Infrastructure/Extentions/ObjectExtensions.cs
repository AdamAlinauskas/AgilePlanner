namespace Infrastructure.Extentions
{
    public static class ObjectExtensions
    {
        public static T DownCastTo<T>(this object target)
        {
            return (T)(target);
        }
    }
}