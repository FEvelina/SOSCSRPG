using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Engine
{
    public static class RandomNrGenerator
    {
        private static readonly RandomNumberGenerator _generator = RandomNumberGenerator.Create();

        public static int NumberBetween(int minValue, int maxValue)
        {
            byte[] randomNumber = new byte[1];
            _generator.GetBytes(randomNumber);
            
            double asciiValeOfRandomCharacter = Convert.ToDouble(randomNumber[0]);

            //substract 0.00000000001 using Math.Max so the "multiplier will" always be [0.0, 1)
            double multiplier = Math.Max(0, (asciiValeOfRandomCharacter / 255d) - 0.00000000001d);

            //add one for rounding when using Math.Floor
            int range = maxValue - minValue + 1;

            double randomValueInRange = Math.Floor(multiplier * range);

            return (int)(minValue+randomValueInRange);
        }

    }
}
