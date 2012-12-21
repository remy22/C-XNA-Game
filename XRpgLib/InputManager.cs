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
    public class InputManager : Microsoft.Xna.Framework.GameComponent
    {
        static KeyboardState keyboardState;
        static KeyboardState lastKeyboardState;
        static MouseState mouseState;
        static MouseState lastMouseState;

        public InputManager(Game game)
            : base(game)
        {
            keyboardState = Keyboard.GetState();
            mouseState = Mouse.GetState();
        }

        public override void Initialize()
        {
            // TODO: Add your initialization code here

            base.Initialize();
        }
        #region Mouse Input
        public static MouseState MouseState
        {
            get { return mouseState; }
        }

        public static float MousePosY
        {
            get { return mouseState.Y; }
        }

        public static float MousePosX
        {
            get { return mouseState.X; }
        }

        public static bool MouseReleased(string button)
        {

            switch (button.ToUpper())
            {
                case "LEFT":
                    return mouseState.LeftButton == ButtonState.Released && lastMouseState.LeftButton == ButtonState.Pressed;
                case "RIGHT":
                    return mouseState.RightButton == ButtonState.Released && lastMouseState.RightButton == ButtonState.Pressed;
                case "MIDDLE":
                    return mouseState.MiddleButton == ButtonState.Released && lastMouseState.MiddleButton == ButtonState.Pressed;
                default:
                    return false;
            }
        }

        public static bool MousePressed(string button)
        {
            switch (button.ToUpper())
            {
                case "LEFT":
                    return mouseState.LeftButton == ButtonState.Pressed && lastMouseState.LeftButton == ButtonState.Released;
                case "RIGHT":
                    return mouseState.RightButton == ButtonState.Pressed && lastMouseState.RightButton == ButtonState.Released;
                case "MIDDLE":
                    return mouseState.MiddleButton == ButtonState.Pressed && lastMouseState.MiddleButton == ButtonState.Released;
                default:
                    return false;
            }
        }

        public static bool MouseDown(string button)
        {
            switch (button.ToUpper())
            {
                case "LEFT":
                    return mouseState.LeftButton == ButtonState.Pressed;
                case "RIGHT":
                    return mouseState.RightButton == ButtonState.Pressed;
                case "MIDDLE":
                    return mouseState.MiddleButton == ButtonState.Pressed;
                default:
                    return false;
            }
        }

        #endregion
        #region Keyboard Input
        public static KeyboardState KeyboardState
        {
            get { return keyboardState; }
        }
        public static KeyboardState LastKeyboardState
        {
            get { return lastKeyboardState; }
        }
        /// <summary>
        /// Sets the last key state to the current key state
        /// </summary>
        public static void SetCurrentKeyState()
        {
            lastKeyboardState = keyboardState;
        }

        public static bool KeyReleased(Keys key)
        {
            return keyboardState.IsKeyUp(key) && lastKeyboardState.IsKeyUp(key);
        }

        public static bool KeyPressed(Keys key)
        {
            return keyboardState.IsKeyDown(key) && lastKeyboardState.IsKeyUp(key);
        }
        public static bool KeyDown(Keys key)
        {
            return keyboardState.IsKeyDown(key);
        }
        #endregion
        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
            lastMouseState = mouseState;
            mouseState = Mouse.GetState();
            lastKeyboardState = keyboardState;
            keyboardState = Keyboard.GetState();
            

            base.Update(gameTime);
        }
    }
}
