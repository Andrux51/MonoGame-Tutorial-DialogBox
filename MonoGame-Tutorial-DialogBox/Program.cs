using System;

namespace MonoGame_Tutorial_DialogBox
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        public static Game1 Game;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var game = new Game1())
            {
                Game = game;
                Game.Run();
            }
        }
    }
#endif
}
