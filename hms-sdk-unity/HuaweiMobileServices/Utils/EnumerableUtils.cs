namespace HuaweiMobileServices.Utils
{
    using System;
    using System.Collections.Generic;

    internal static class EnumerableUtils
    {

        public static IList<U> Map<T, U>(this IList<T> list, Func<T, U> action)
        {
            if (list == null) return null;
            var newList = new List<U>();
            foreach (T element in list)
            {
                newList.Add(action.Invoke(element));
            }
            return newList;
        }

        public static ISet<U> Map<T, U>(this ISet<T> set, Func<T, U> action)
        {
            if (set == null) return null;
            var newSet = new HashSet<U>();
            foreach (T element in set)
            {
                newSet.Add(action.Invoke(element));
            }
            return newSet;
        }
    }
}
