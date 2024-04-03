using WordSearcher;
namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[][] boardChars = [['A', 'B', 'C', 'E'], ['S', 'F', 'C', 'S'], ['A', 'D', 'E', 'E']];
            string word = "ABCCED";
            var wordchecker = new Solution();
            Console.WriteLine(wordchecker.Exist(boardChars, word));
        }
    }
}
