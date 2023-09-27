using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeusPalace.Entities.Accommodation
{
    internal class TrojanHorse : Accommodation
    {
        public override AccommodationType Type => AccommodationType.TrojanHorse;

        public TrojanHorse()
        {
            Id = GenerateId();
        }

        public override string GenerateId()
        {
            int firstDigit = 0;

            // Generate the last two digits (01 to 50)
            int lastTwoDigits = random.Next(1, 51); // Generates a random integer from 1 to 50

            // Format the number as a string with leading zeros if needed
            string formattedLastTwoDigits = lastTwoDigits.ToString("D2");

            // Combine the digits and return as a string
            string result = $"{firstDigit}{formattedLastTwoDigits}";

            return result;
        }
    }
}
