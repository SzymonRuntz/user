using System;
using System.Linq;

namespace ExtensionMethods
{
    // Rule number one: Class which contains extension methods must be static
    public static class StringExtensions
    {
        // Rule number two: Extension method must be static itself
        // Rule number thre: type we want to extend is the first parameter of method and we must mark it with 'this' keyword
        public static int CountWordsInSentence(this string sentence)
        {
            return sentence.Split(new[] { ' ', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries).Count();
        }
    }
}
