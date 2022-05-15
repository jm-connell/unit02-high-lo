using Unit02.Game;

namespace Unit02
{
    /// <summary>
    /// The program's entry point.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>
        static void Main(string[] args)
        {
            Card currentCard = new Card();
            currentCard.Draw();
            Card nextCard = new Card();
            nextCard.Draw();

            Director director = new Director();
            director.StartGame(currentCard, nextCard);
        }
    }
}