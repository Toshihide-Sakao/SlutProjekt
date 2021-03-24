using System;
using Raylib_cs;

namespace BitcoinMiner
{
    public enum Controlls
    {
        Up = KeyboardKey.KEY_W,
        Down = KeyboardKey.KEY_S,
        Left = KeyboardKey.KEY_A,
        Right = KeyboardKey.KEY_D,
        Shoot = MouseButton.MOUSE_LEFT_BUTTON,
        Magic = MouseButton.MOUSE_RIGHT_BUTTON
    }
}
