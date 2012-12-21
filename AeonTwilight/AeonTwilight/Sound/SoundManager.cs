using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;


namespace AeonTwilight.Sound
{
    class SoundManager
    {
        /// <summary>
        /// Create singleton class
        /// </summary>
        /// 
        public static SoundManager soundManager;
        public static Dictionary<string, SoundEffect> sounds;
        private SoundManager()
        {
            sounds = new Dictionary<string, SoundEffect>();

        }

        /// <summary>
        /// return only the current working instance of the class
        /// </summary>
        public static void getInstance(ContentManager content)
        {
            if (soundManager != null)
            {
                return;
            }
            else
            {
                soundManager = new SoundManager();
            }
        }

        /// <summary>
        /// Load a sound into the list of sounds available
        /// </summary>
        public static void loadSound(ContentManager content, string name)
        {
            sounds.Add(name, content.Load<SoundEffect>(@"Audio"+name));
        }

        /// <summary>
        /// play a sound in the list of available sounds
        /// </summary>
        public static void playSound(string soundName)
        {
            try
            {
                sounds[soundName].Play();
            }
            catch(Exception)
            {
                throw;
            }
            
        }
    }
}
