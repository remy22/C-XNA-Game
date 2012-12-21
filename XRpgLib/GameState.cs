using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace XRpgLib
{
    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
    public class GameState : DrawableGameComponent
    {
        List<GameComponent> gameComponents;

        public List<GameComponent> Components
        {
            get { return gameComponents; }
        }

        GameState Id;

        public GameState ID
        {
            get { return Id; }
        }

        protected GameStateManager StateManager;

        public GameState(Game game, GameStateManager manager)
            : base(game)
        {
            StateManager = manager;
            gameComponents = new List<GameComponent>();
            Id = this;
        }

        /// <summary>
        /// query for any required services and load content.
        /// </summary>
        public override void Initialize()
        {
            // TODO: Add your initialization code here

            base.Initialize();
        }

        /// <summary>
        /// Allows sub components to handle rendering
        /// </summary>
        /// <param name="gameTime"></param>
        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }
        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
            // TODO: Add your update code here

            base.Update(gameTime);
        }
    }
}
