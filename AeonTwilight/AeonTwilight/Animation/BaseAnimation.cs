using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace AeonTwilight.Animation
{
    class BaseAnimation
    {
        const int defaultMillisecondsPerFrame = 16;
        private Point frameSize;
        private Point currentFrame;
        private Point sheetSize;
        private Texture2D textureSheet;

        int timeSinceLastFrame = 0;
        int millisecondsPerFrame;

        /// <summary>
        /// default constructor
        /// </summary>
        /// <param name="textureSheet"></param>
        /// <param name="frameSize"></param>
        /// <param name="sheetSize"></param>
        public BaseAnimation(Texture2D textureSheet, Point frameSize, Point sheetSize)
        {
            this.frameSize = frameSize;
            this.textureSheet = textureSheet;
            this.sheetSize = sheetSize;
            this.millisecondsPerFrame = defaultMillisecondsPerFrame;
        }

        /// <summary>
        /// overloaded constructor for changing the animation speed
        /// </summary>
        /// <param name="textureSheet"></param>
        /// <param name="frameSize"></param>
        /// <param name="sheetSize"></param>
        /// <param name="millisecondsPerFrame"></param>
        public BaseAnimation(Texture2D textureSheet, Point frameSize, Point sheetSize, int millisecondsPerFrame)
        {
            this.frameSize = frameSize;
            this.textureSheet = textureSheet;
            this.sheetSize = sheetSize;
            this.millisecondsPerFrame = millisecondsPerFrame;
        }

        /// <summary>
        /// Base animation logic for animating a spritesheet
        /// </summary>
        /// <param name="gameTime"></param>
        public void animate(GameTime gameTime)
        {
            if (timeSinceLastFrame > millisecondsPerFrame)
            {
                timeSinceLastFrame = 0;
                ++currentFrame.X;
                if (currentFrame.X >= sheetSize.X)
                {
                    currentFrame.X = 0;
                    ++currentFrame.Y;
                    if (currentFrame.Y >= sheetSize.Y)
                    {
                        currentFrame.Y = 0;
                    }
                }
            }
        }
    }
}
