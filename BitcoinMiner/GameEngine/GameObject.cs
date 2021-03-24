using System;
using System.Numerics;
using Raylib_cs;

namespace BitcoinMiner.GameEngine
{
    public class GameObject
    {
        protected Vector2 position;
        protected Vector2 size;
        protected string spritePath;
        protected bool hasSprite;
        
        public Vector2 Position
        {
            get { return position; }
            set { position = value; }
        }

        public Vector2  Size
        {
            get { return size; }
            set { size = value; }
        }
    }
}
