using System;

namespace MyLibrary
{
    public class MyConverter
    {
        public static T Parse<T>(object obj)
        {
            if (obj.ToString().Trim() == "")
            {
                return default(T);
            }
            return (T)(Convert.ChangeType(obj, typeof(T)));
        }
    }
}
