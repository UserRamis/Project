﻿using System;

namespace HOM
{
    class MyGame : IGame
    {
        public void Play(string name)
        {
            Console.WriteLine($"name играет в прятки");
        }
    }
}