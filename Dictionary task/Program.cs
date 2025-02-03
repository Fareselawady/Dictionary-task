
namespace Dictionary_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var article = "the quick brown fox jumps over the lazy dog" + " i wish i was the monster that you think i am "
                + "She likes to read books in the evening" + "He is learning English to speak with his friends";

            Dictionary<char, List<string>> letters = new Dictionary<char, List<string>>();
            foreach (var word in article.Split())
            {
                foreach (var letter in word)
                {
                    var c = char.ToLower(letter);
                    if (!letters.ContainsKey(c))
                    {
                        letters.Add(c, new List<string> { word.ToLower() });

                    }
                    else
                    {
                        letters[c].Add(word);

                    }
                }
            }
            foreach (var item in letters)
            {
                Console.WriteLine($"'{item.Key}' : ");
                foreach (var word in item.Value)
                {
                    Console.WriteLine($"\t \t {word}");
                }
            }



        }
    }

}
