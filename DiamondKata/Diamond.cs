namespace DiamondKata
{
    public static class Diamond
    {
        public static List<char> Letters() => new List<char>() {'A', 'B', 'C', 'D', 'E', 'F',
                     'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T',
                     'U', 'V', 'W', 'X', 'Y', 'Z' };

        public static string Create(char input)
        {
            var alphabet = Letters();
            var alphabetIndex = alphabet.IndexOf(input) + 1;
            var subsetLetters = alphabet.Take(alphabetIndex).ToList();
            var result = "";
            foreach(var l in subsetLetters)
            {
                result += l.ToString();
            }
            return result;
        }
    }
}
