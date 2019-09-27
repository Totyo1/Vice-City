﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ViceCity.Models.Players
{
    class CivilPlayer : Player
    {
        private const int initialLP = 50;
        public CivilPlayer(string name) : base(name, initialLP)
        {
        }
    }
}