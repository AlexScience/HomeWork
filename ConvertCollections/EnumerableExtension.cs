namespace ConvertCollections;

public static class EnumerableExtension
{
    public static IEnumerable<K> Convert<T, K>(this IEnumerable<T> collection)
    {
        foreach (var items in collection)
        {
            if (items is K convertItem)
            {
                yield return convertItem;
            }
            else
            {
                throw new InvalidCastException("Invalid convert");
            }
        }
    }
}