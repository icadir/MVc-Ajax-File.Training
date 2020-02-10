using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVc_Ajax_File.Training.Utilities
{
    public static class UtilityManager
    {
       public static byte[] ByteBirlestir(byte[] arrayA, byte[] arrayB)
        {
            byte[] outputBytes = new byte[arrayA.Length + arrayB.Length];
            Buffer.BlockCopy(arrayA, 0, outputBytes, 0, arrayA.Length);
            Buffer.BlockCopy(arrayB, 0, outputBytes, arrayA.Length, arrayB.Length);
            return outputBytes;
        }
    }
}