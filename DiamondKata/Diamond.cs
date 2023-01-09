namespace DiamondKata
{
    public static class Diamond
    {
        public static List<char> Letters() => new List<char>() {'A', 'B', 'C', 'D', 'E', 'F',
                     'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T',
                     'U', 'V', 'W', 'X', 'Y', 'Z' };

        public static string Create(char input)
        {
            input = char.ToUpper(input);
            var alphabet = Letters();

            if (!alphabet.Contains(input))
            {
                throw new Exception("Invalid input");
            }

            var inputIndex = alphabet.IndexOf(input) + 1;

            var subset = alphabet.Take(inputIndex).ToList();
            string topOfDiamond = CreateTriangleFromSubset(alphabet, subset, inputIndex, 1);

            var subsetWithoutInput = alphabet.Take(inputIndex - 1).ToList();
            subsetWithoutInput.Reverse();
            string bottomOfDiamond = CreateTriangleFromSubset(alphabet, subsetWithoutInput, inputIndex, 0);

            return topOfDiamond + bottomOfDiamond;
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
                result += " ";
            }

            result += letter.ToString();
            return result;
        }
    }
}
