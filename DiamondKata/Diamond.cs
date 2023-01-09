namespace DiamondKata
{
    public static class Diamond
    {
        public static List<char> Letters() => new List<char>() {'A', 'B', 'C', 'D', 'E', 'F',
                     'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T',
                     'U', 'V', 'W', 'X', 'Y', 'Z' };

        public static string Create(string input)
        {
            var alphabet = Letters();

            if (input.Length != 1)
            {
                throw new Exception($"Invalid input of '{input}'");
            }

            var letter = input.ToUpper()[0];
            if (!alphabet.Contains(letter))
            {
                throw new Exception($"Invalid input of '{input}'");
            }

            var alphabetIndex = alphabet.IndexOf(letter) + 1;

            var subset = alphabet.Take(alphabetIndex).ToList();
            string topOfDiamond = CreateTriangleFromSubset(alphabet, subset, alphabetIndex, 1);

            var subsetWithoutInput = alphabet.Take(alphabetIndex - 1).ToList();
            subsetWithoutInput.Reverse();
            string bottomOfDiamond = CreateTriangleFromSubset(alphabet, subsetWithoutInput, alphabetIndex, 0);

            return topOfDiamond + bottomOfDiamond;
        }

        private static string CreateTriangleFromSubset(List<char> alphabet, List<char> subset, int alphabetIndex, int offset)
        {
            var result = "";
            foreach (var letter in subset)
            {
                if (letter == 'A')
                {
                    result = WriteLine(result, letter, alphabetIndex-1);
                }
                else
                {
                    var leftPadding = Math.Abs(subset.Count() - alphabet.IndexOf(letter) - offset);
                    result = WriteLine(result, letter, leftPadding);

                    var middleGap = (alphabet.IndexOf(letter) * 2) - 1;
                    result = WriteLine(result, letter, middleGap);
                }
                result += "\n";
            }

            return result;
        }

        private static string WriteLine(string result, char letter, int range)
        {
            for (int i = 0; i < range; i++)
            {
                result += " ";
            }

            result += letter.ToString();
            return result;
        }
    }
}
