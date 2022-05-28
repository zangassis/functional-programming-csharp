namespace FPExampleApp
{
    public static class Helper
    {
        public static IEnumerable<T> MyWhere<T>
            (this IEnumerable<T> source, Func<T, bool> predicate)
        {
            foreach (T s in source)
                if (predicate(s))
                    yield return s;
        }
    }
}