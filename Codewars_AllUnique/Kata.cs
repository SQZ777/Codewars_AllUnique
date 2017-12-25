using System;
using System.Linq;

namespace Codewars_AllUnique
{
    public class Kata
    {
        public bool HasUniqueChars(string input)
        {
            foreach (char c in input)
            {
                if (input.Count(x => x.Equals(c)) > 1)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
