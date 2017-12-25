using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Codewars_AllUnique
{
    public class Kata
    {
        public bool HasUniqueChars(string input)
        {
            return input.All(c => input.Count(x => x.Equals(c)) <= 1);
        }
    }
}
