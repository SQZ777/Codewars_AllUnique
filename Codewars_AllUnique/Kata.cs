using System;
using System.Linq;

namespace Codewars_AllUnique
{
    public class Kata
    {
        public bool HasUniqueChars(string input)
        {
            if (input.Count(x => x == input[0]) > 1)
                return false;
            return true;
        }
    }
}
