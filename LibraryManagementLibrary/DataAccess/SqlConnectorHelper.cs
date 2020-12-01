using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagementLibrary.DataAccess
{
    public static class SqlConnectorHelper
    {

        public static List<T> SqlConcat<T>(this List<T> first, List<T> second) where T : class
        {
            return first.Union(second).ToList();
        }

    }
}
