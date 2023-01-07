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
            var inputIndex = alphabet.IndexOf(input) + 1;

            string topOfDiamond = CreateTopOfDiamond(alphabet, inputIndex);
            string bottomOfDiamond = CreateBottomOfDiamond(alphabet, inputIndex);

            return topOfDiamond + bottomOfDiamond;
        }

        private static string CreateBottomOfDiamond(List<char> alphabet, int inputIndex)
        {
            var subsetWithoutInput = alphabet.Take(inputIndex - 1).ToList();
            subsetWithoutInput.Reverse();
            var bottomOfDiamond = CreateTriangleFromSubset(alphabet, subsetWithoutInput, inputIndex, 0);
            return bottomOfDiamond;
        }

        private static string CreateTopOfDiamond(List<char> alphabet, int inputIndex)
        {
            var subset = alphabet.Take(inputIndex).ToList();
            var topOfDiamond = CreateTriangleFromSubset(alphabet, subset, inputIndex, 1);
            return topOfDiamond;
        }

        private static string CreateTriangleFromSubset(List<char> alphabet, List<char> subset, int inputIndex, int offset)
        {
            var result = "";
            foreach (var letter in subset)
            {
                if (letter == 'A')
                {
                    result = WriteLine(result, letter, inputIndex-1);

                }
                else
                {
                    var leftPadding = Math.Abs(subset.Count() - offset - alphabet.IndexOf(letter));
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
                result += "_";
            }

            result += letter.ToString();
            return result;
        }
    }
}
