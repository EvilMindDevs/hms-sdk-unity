using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiMobileServices.Utils
{
    class ListUtils
    {

        private ListUtils() { }

        public static IList<U> Map<T, U>(IList<T> list, Func<T, U> action)
        {
            var newList = new List<U>();
            foreach(T element in list)
            {
                newList.Add(action.Invoke(element));
            }
            return newList;
        }
    }
}
