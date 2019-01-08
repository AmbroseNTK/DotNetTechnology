using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace W03
{
    public static class MyExtensions
    {
        /// <summary>
        /// Add hashing function to String objects
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static string HashingMD5(this String val)
        {
            MyLibrary.CommonUtils.HashingMD5(ref val);
            return val;
        }
    }
}
