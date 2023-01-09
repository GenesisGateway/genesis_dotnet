using System;
using System.Security.Cryptography;
using System.Text;

namespace Genesis.NetCore.Common.ThreedsV2
{
    /// <remarks />
    public static class Helpers
    {
        /// <remarks />
        public static string CreateSHA512Hash(string concatenatedStrings)
        {
            var hashAlgorithm = SHA512.Create();
            var hash = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(concatenatedStrings));
            var signature = BitConverter.ToString(hash).Replace("-", string.Empty);
            return signature.ToLowerInvariant();
        }

        /// <remarks />
        public static string CreateSHA512Hash(params string[] elements)
        {
            return CreateSHA512Hash(string.Concat(elements));
        }
    }
}
