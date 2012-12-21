using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using AeonTwilight.Sound;
using AeonTwilight.Animation;

namespace AeonTwilight.Entity
{
    abstract class GameEntity
    {
        public static Point defaultFrameSize = new Point(32, 32);
        public string entity_name;
        protected Dictionary<string, BaseAnimation> animations = new Dictionary<string, BaseAnimation>();
        protected Texture2D textureImage;
        protected Point frameSize;

        public GameEntity(Texture2D texture, Point frameSize, Point sheetSize, string name)
        {
            this.textureImage = texture;
            entity_name = name;
            this.frameSize = frameSize;
            animations.Add("idle", new BaseAnimation(textureImage, this.frameSize, sheetSize));
        }
        public GameEntity(Texture2D texture, Point sheetSize, string name)
        {
            this.textureImage = texture;
            entity_name = name;
            this.frameSize = defaultFrameSize;
            animations.Add("idle", new BaseAnimation(textureImage, this.frameSize, sheetSize));
        }
        public virtual void Update(GameTime time)
        {
        }

        public virtual void Draw(GameTime time, SpriteBatch spriteBatch)
        { 
        }

        /// <summary>
        /// Add a new animation to the entities list of different animations
        /// </summary>
        /// <param name="actionName"></param>
        /// <param name="textureSheet"></param>
        /// <param name="sheetSize"></param>
        public void addAnimationType(string actionName, Texture2D textureSheet, Point sheetSize)
        {
            animations.Add(actionName, new BaseAnimation(textureSheet, this.frameSize, sheetSize));
        }

        /// <summary>
        /// Default animation when left idle
        /// </summary>
        private void animateIdle(GameTime time)
        {
            animations["idle"].animate(time);
        }

        /// <summary>
        /// animate a specific action
        /// </summary>
        /// <param name="actionType"></param>
        private void animateAction(string actionType, GameTime time)
        {
            animations[actionType].animate(time);
        }
    }
}
