using System;
using System.Collections.Generic;
using System.Text;

namespace AmericanRoulette
{
    /// <summary>
    /// Random number generator
    /// </summary>
    class RouletteLuck : ILuckTeller
    {
        private readonly Random ball;
        /// <summary>
        /// Initialize the Random object
        /// </summary>
        public RouletteLuck()
        {
            ball = new Random();
        }

        /// <inheritdoc />
        public byte Generate(byte maxSize) => (byte)ball.Next(maxSize);
    }
}
