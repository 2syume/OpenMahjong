using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.Linq;

namespace OpenMahjong.Logic.Common.Utils
{
    public static class Shuffler
    {
        static Shuffler()
        {
            rnd = new RNGCryptoServiceProvider();
        }

        public static T[] Shuffle<T>(this IEnumerable<T> array)
        {
            return array.OrderBy(x => GetNextInt32(rnd)).ToArray();
        }

        private static int GetNextInt32(RNGCryptoServiceProvider rnd)
        {
            byte[] randomInt = new byte[4];
            rnd.GetBytes(randomInt);
            return Convert.ToInt32(randomInt[0]);
        }

        private static RNGCryptoServiceProvider rnd;
    }
}
