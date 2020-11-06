using ExtensionMethods;

namespace AnotherProjectWichNeedExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence3 = "Very wierd sentence. With another sentence";

            var sentence4 = "Is this a sentence? Or maybe not?";

            var words3 = sentence3.CountWordsInSentence();

            var words4 = sentence4.CountWordsInSentence();
        }
    }
}
