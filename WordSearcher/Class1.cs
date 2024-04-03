namespace WordSearcher
{
    public class Class1
    {
        public bool Exist(char[][] board, string word)
        {
            for (int x = 0; x < board.Length; x++)
            {
                for (int y = 0; y < board[x].Length; y++)
                {
                    if (board[x][y] == word[0])
                    {
                        for (int i = 1; i < word.Length; i++)
                        {
                            if (!checkAdjacent(word[i], board[x - 1][y], board[x + 1][y], board[]))
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }

        public bool checkAdjacent(char letter, char? up, char? down, char? left, char? right)
        {

        }
    }
}
