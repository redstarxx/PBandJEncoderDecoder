﻿namespace PBandJEncoderDecoder
{
    public class EncoderDecoderUtilities
    {
        public static Dictionary<string, string> encodedCharacters = new Dictionary<string, string>()
        {
            { "a", "./" },
            { "b", "../" },
            { "c", ".../" },
            { "d", "..../" },
            { "e", "-/" },
            { "f", "-./" },
            { "g", "-../" },
            { "h", "-.../" },
            { "i", "-..../" },
            { "j", "0/" },
            { "k", "0./" },
            { "l", "0../" },
            { "m", "0.../" },
            { "n", "0..../" },
            { "o", "0-/" },
            { "p", "0-./" },
            { "q", "0-../" },
            { "r", "0-.../" },
            { "s", "0-..../" },
            { "t", "00/" },
            { "u", "00./" },
            { "v", "00../" },
            { "w", "00.../" },
            { "x", "00..../" },
            { "y", "00-/" },
            { "z", "00-./" },
            { " ", "/" }
        };

        public static string Encode(string input)
        {
            StringBuilder convertedCharacters = new StringBuilder();

            foreach (char c in input)
            {
                string rawCharacter = c.ToString();

                convertedCharacters.Append(string.Join("\n", encodedCharacters.Where(x => x.Key == rawCharacter).Select(x => x.Value)));
            }

            return convertedCharacters.ToString();
        }

        public static string Decode(string input)
        {
            StringBuilder convertedCharacters = new StringBuilder();

            string encodedCharacter = string.Empty;

            foreach (char c in input)
            {
                char space = '/';

                encodedCharacter = encodedCharacter + c;

                if (c == space)
                {
                    convertedCharacters.Append(string.Join("\n", encodedCharacters.Where(x => x.Value == encodedCharacter).Select(x => x.Key)));

                    encodedCharacter = string.Empty;
                }
            }

            return convertedCharacters.ToString();
        }
    }
}
