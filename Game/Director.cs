using System;
using System.Collections.Generic;

namespace Unit02.Game
{
    /// <summary>
    /// A person who directs the game. 
    ///
    /// The responsibility of a Director is to control the sequence of play.
    /// </summary>
    public class Director
    {
        public bool isPlaying = true;
        public int totalScore = 300;
        public string userGuess = string.Empty;

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
            Console.WriteLine();
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame(Card currentCard, Card nextCard)
        {
            while (isPlaying)
            {
                GetInputs(currentCard, nextCard);
                DoUpdates(currentCard, nextCard);
                DoOutputs(currentCard, nextCard);
            }
        }

        /// <summary>
        /// Displays current card and prompts for guess.
        /// </summary>
        public void GetInputs(Card currentCard, Card nextCard)
        {
            /// Display current card and display guess prompt
            Console.WriteLine($"The card is: {currentCard._cardValue}");
            Console.Write("Higher or lower? [h/l] ");

            /// Get guess from user and convert to int
            userGuess = Console.ReadLine();
        }

        /// <summary>
        /// Updates the player's score and gets new card values
        /// </summary>
        public void DoUpdates(Card currentCard, Card nextCard)
        {
            /// If guess is correct add 100 points, if wrong subtract 75
            if (((userGuess == "h") && (nextCard._cardValue > currentCard._cardValue)) || 
            ((userGuess == "l") && (nextCard._cardValue < currentCard._cardValue)))
            {
                totalScore += 100;
            }
            else
            {
                totalScore -= 75;
            }

            /// Update card values
            currentCard._cardValue = nextCard._cardValue;
            nextCard.Draw();
        }

        /// <summary>
        /// Displays result and the score. Also asks the player if they want to play again. 
        /// </summary>
        public void DoOutputs(Card currentCard, Card nextCard)
        {
            /// Display next card
            Console.WriteLine($"Next card was: {currentCard._cardValue}");

            /// If user hits 0 points, end program
            if (totalScore <= 0)
            {
                Console.WriteLine("Sorry, you lose!");
                System.Environment.Exit(1);
            }

            /// Display score and prompt for play again
            Console.WriteLine($"Your score is: {totalScore}");
            Console.Write("Play again? [y/n] ");
            string playAgainInput = Console.ReadLine();
            Console.WriteLine();
            isPlaying = (playAgainInput == "y");
        }

    }
}

