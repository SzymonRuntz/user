using System;
using System.Linq;
using static ExtensionMethods.StringExtensions;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // DRY -> Don't Repeat Yourself
            var sentence1 = "My first sentence.";

            var sentence2 = "My seceond sentence and different sentence.";

            var sentence3 = "This is wrong sentence!Remove it.";

            var words1 = sentence1.CountWordsInSentence();

            // before extension method
            /// var words2 = CountWordsInSentence(sentence2);

            // after extension method
            var words3 = sentence3.CountWordsInSentence();
        }
    }
}
