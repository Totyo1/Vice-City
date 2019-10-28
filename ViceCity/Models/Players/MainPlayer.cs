using System;
using System.Collections.Generic;
using System.Text;

namespace ViceCity.Models.Players
{
    class MainPlayer : Player
    {

        private const string MainName = "Tommy Vercetti";
        private const int MainInitialLife = b100;
        public MainPlayer() : base(MainName, MainInitialLife)
        {

        }
    }
}
