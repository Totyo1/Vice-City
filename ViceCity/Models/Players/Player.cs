using System;
using System.Collections.Generic;
using System.Text;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Models.Players.Contracts;
using ViceCity.Repositories.Contracts;

namespace ViceCity.Models.Players
{
    public abstract class Player : IPlayer
    {
        private string name;
        private int lifePoints;
        public IRepository<IGun> GunRepository { get; set; }

        protected Player(string name, int lifePoints)
        {
            this.Name = name;
            this.LifePoints = lifePoints;
            
        }

        public string Name
        {
            get => this.name;
           protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Player's name cannot be null or a whitespace!");
                }
                this.name = value;
            }
        }

        public int LifePoints
        {
            get => this.lifePoints;
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Player life points cannot be below zero!");
                }
                this.lifePoints = value;
            }
        }

        public bool IsAlive
        {
            get => this.IsAlive;
            private set
            {
                if (this.lifePoints > 0)
                {
                    value = true;
                }
                value = false;
            }
        }

        public void TakeLifePoints(int points)
        {
            this.lifePoints -= points;
            if (this.lifePoints < 0)
            {
                this.lifePoints = 0;
            }
        }
    }
}
