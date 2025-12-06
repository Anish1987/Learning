using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine.Tests
{
    public class GameStateFixture : IDisposable
    {
        //moCk

        public GameState State { get; private set; }

        public GameStateFixture()
        {
            State = new GameState();
        }

        public void Dispose()
        {
            // Cleanup
        }
    }
}
