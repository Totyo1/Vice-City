using System;
using System.Collections.Generic;
using System.Text;

namespace ViceCity.Models.Players
{
    public class MainPlayer : Player
    {

        private const string mainName = "Tommy Vercetti";
        private const int initialLP = 100;

        public MainPlayer() : base(mainName, initialLP)
        {

        }
    }
}
