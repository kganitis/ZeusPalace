using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeusPalace.Entities.Accommodation
{
    internal class Apartment : Accommodation
    {
        public override AccommodationType Type => AccommodationType.Apartment;

        public Apartment()
        {
            Id = GenerateId();
        }

        public override string GenerateId()
        {
            // Generate the first digit (1 to 6)
            int firstDigit = random.Next(1, 7); // Generates a random integer from 1 to 6

            // Generate the last two digits (01 to 20)
            int lastTwoDigits = random.Next(1, 21); // Generates a random integer from 1 to 20

            // Format the number as a string with leading zeros if needed
            string formattedLastTwoDigits = lastTwoDigits.ToString("D2");

            // Combine the digits and return as a string
            string result = $"{firstDigit}{formattedLastTwoDigits}";

            return result;
        }
    }
}
