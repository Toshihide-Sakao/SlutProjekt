using System;
using BitcoinMiner.GameEngine;

namespace BitcoinMiner.Character
{
    public abstract class Character : GameObject
    {
        protected string name;
        protected int HP;

        public abstract void Update();
    }
}
