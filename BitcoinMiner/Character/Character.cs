using System;
using BitcoinMiner.GameEngine;

namespace BitcoinMiner.Character
{
    public class Character : GameObject
    {
        protected string name;
        protected int HP;

        public void Update() 
        {
            
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
