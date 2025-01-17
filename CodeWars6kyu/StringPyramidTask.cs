using CodeWars6kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class StringPyramidTask
    {
        public static string WatchPyramidFromTheSide(string characters)
        {
            if (string.IsNullOrEmpty(characters))
            { 
                return characters; 
            }

            string pyramid = "";
            var baseOfPyramid = characters.Length * 2 - 1; 
            int iterator = 0;
            var blockForPyramid = characters.Reverse().ToArray();
            int iteratorForBlock = 1;
            int iteratorForSpaces = 1;

            while (iterator != characters.Length)
            {
                pyramid += string.Concat(Enumerable.Repeat(" ", (baseOfPyramid - iteratorForSpaces) / 2)) 
                    + string.Concat(Enumerable.Repeat(blockForPyramid[iterator], iteratorForBlock)) 
                    + string.Concat(Enumerable.Repeat(" ", (baseOfPyramid - iteratorForSpaces) / 2)) 
                    + "\n";

                iteratorForBlock += 2;
                iteratorForSpaces+=2;
                iterator++;
            }

            return pyramid.TrimEnd('\n');
        } 

        public static string WatchPyramidFromAbove(string characters)
        {
            if (string.IsNullOrEmpty(characters))
            {
                return characters;
            }

            int n = characters.Length;
            int baseWidth = n * 2 - 1;

            char[][] pyramid = new char[baseWidth][];
            for (int i = 0; i < baseWidth; i++)
            {
                pyramid[i] = new char[baseWidth];
                Array.Fill(pyramid[i], characters[0]);
            }

            for (int i = 1; i < n; i++)
            {
                int start = i;
                int end = baseWidth - i - 1;

                for (int j = start; j <= end; j++)
                {
                    pyramid[start][j] = characters[i];
                    pyramid[end][j] = characters[i];
                    pyramid[j][start] = characters[i];
                    pyramid[j][end] = characters[i];
                }
            }

            return string.Join("\n", pyramid.Select(row => new string(row)));
        }

        public static int CountVisibleCharactersOfThePyramid(string characters)
        {
            if (string.IsNullOrEmpty(characters))
            {
                return -1;
            }

            int n = characters.Length;
            int baseWidth = n * 2 - 1;

            return baseWidth * baseWidth;
        }

        public static int CountAllCharactersOfThePyramid(string characters)
        {
            if (string.IsNullOrEmpty(characters))
            {
                return -1;
            }

            int n = characters.Length;
            int totalCharacters = 0;

            for (int i = 1; i <= n; i++)
            {
                int layerWidth = i * 2 - 1;
                totalCharacters += layerWidth * layerWidth;
            }

            return totalCharacters;
        }
    }
}
//https://www.codewars.com/kata/5797d1a9c38ec2de1f00017b/train/csharp