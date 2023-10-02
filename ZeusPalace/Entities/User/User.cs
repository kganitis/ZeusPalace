using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeusPalace
{
    public abstract class User
    {
        public string Name { get; set; }
        public abstract UserRole Role { get; }
        public string Username { get; set; }
        public string Password { get; set; }

        protected static string GenerateUsernameFromName(string name)
        {
            // Split the full name into parts
            string[] nameParts = name.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (nameParts.Length < 2)
            {
                throw new ArgumentException("Invalid full name. It should contain at least a first name and a last name.");
            }

            // Initialize the StringBuilder for the username
            StringBuilder usernameBuilder = new StringBuilder();

            foreach (string part in nameParts)
            {
                // Extract the first 3 letters of each part
                string extractedLetters = ExtractFirstLetters(part, 5 - Math.Min(nameParts.Length, 4));

                // Convert the extracted letters to Latin characters and append to the result
                usernameBuilder.Append(ConvertGreekCharactersToLatin(extractedLetters));
            }

            return usernameBuilder.ToString();
        }

        // Extract the first 3 letters of a part while handling special characters
        protected static string ExtractFirstLetters(string part, int numberOfLetters = int.MaxValue)
        {
            StringBuilder extractedLetters = new StringBuilder();

            for (int i = 0; i < Math.Min(numberOfLetters, part.Length); i++)
            {
                string currentChar = part[i].ToString();
                string convertedChar = ConvertGreekCharactersToLatin(currentChar);

                // Append the converted character to the result
                extractedLetters.Append(convertedChar);
            }

            return extractedLetters.ToString();
        }

        // A mapping of Greek characters to Latin characters
        private static string ConvertGreekCharactersToLatin(string greekCharacter)
        {
            string greekChar = greekCharacter.ToLowerInvariant();
            switch (greekChar)
            {
                case "α": return "a";
                case "β": return "b";
                case "γ": return "g";
                case "δ": return "d";
                case "ε": return "e";
                case "ζ": return "z";
                case "η": return "i";
                case "θ": return "th";
                case "ι": return "i";
                case "κ": return "k";
                case "λ": return "l";
                case "μ": return "m";
                case "ν": return "n";
                case "ξ": return "x";
                case "ο": return "o";
                case "π": return "p";
                case "ρ": return "r";
                case "σ":
                case "ς": return "s";
                case "τ": return "t";
                case "υ": return "u";
                case "φ": return "f";
                case "χ": return "ch";
                case "ψ": return "ps";
                case "ω": return "o";
                case "ά": return "a";
                case "έ": return "e";
                case "ί": return "i";
                case "ή": return "i";
                case "ό": return "o";
                case "ώ": return "o";
                case "ύ": return "u";
                default: return greekChar;
            }
        }
    }

}
