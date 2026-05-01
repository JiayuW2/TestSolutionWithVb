using System;
using Newtonsoft.Json;

namespace AppUtils
{
    public class MathHelper
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static string ToJson(object value)
        {
            return JsonConvert.SerializeObject(value);
        }
    }
}
