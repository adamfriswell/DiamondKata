﻿namespace DiamondKata
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
            var bottomOfDiamond = CreateTriangleFromSubset(alphabet, subsetWithoutInput);
            return bottomOfDiamond;
        }

        private static string CreateTopOfDiamond(List<char> alphabet, int inputIndex)
        {
            var subset = alphabet.Take(inputIndex).ToList();
            var topOfDiamond = CreateTriangleFromSubset(alphabet, subset);
            return topOfDiamond;
        }

        private static string CreateTriangleFromSubset(List<char> alphabet, List<char> subset)
        {
            var result = "";
            foreach (var letter in subset)
            {
                var letterIndex = alphabet.IndexOf(letter) + 1;
                for (int i = 0; i < letterIndex; i++)
                {
                    result += letter.ToString();
                }
                result += "\n";
            }

            return result;
        }
    }
}
