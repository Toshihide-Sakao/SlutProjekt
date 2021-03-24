using System;
using System.Numerics;
using System.Collections.Generic;
using Raylib_cs;
using BitcoinMiner.GameEngine;

namespace BitcoinMiner.Character
{
    public class MainCharacter : Character
    {
        private int exp;
        private int[] upgrades;
        
        private int mana;
        private Dictionary<string, int> damages; 
        
        public MainCharacter(string name, Vector2 position, Vector2 size, bool hasSprite = false, string spritePath = "")
        {
            this.name = name;
            this.position = position;
            this.size = size;
            this.hasSprite = hasSprite;
            this.spritePath = spritePath;
            this.exp = 0;
            this.mana = 60;
        }

        
        public int Exp 
        {
            get { return exp; }
        } 
        public int[] Upgrades
        {
            get { return upgrades; }
            set { upgrades = value; }
        }
    }
}
