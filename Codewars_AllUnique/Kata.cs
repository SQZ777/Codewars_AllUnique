using System;
using System.Linq;

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
