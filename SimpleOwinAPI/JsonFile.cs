using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleOwinAPI
{
    public static class JsonFile
    {
        public static string Load(IEnumerable<string> pathSegements)
        {
            return pathSegements.Aggregate((cur, next) => cur + "." + next) + ".json";
        }
    }
}