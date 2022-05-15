using System;

namespace Unit02.Game
{
    /// <summary>
    /// A playing card with a value of 1-13
    /// </summary> 
    public class Card
    {
        public int _cardValue = 0;

        /// <summary>
        /// Constructs a new instance of Card.
        /// </summary>
        public Card()
        {
        }

        /// <summary>
        /// Generates a new random card value
        /// </summary>
        public void Draw()
        {
            Random random = new Random();
            _cardValue = random.Next(1, 14);
        }

    }
}