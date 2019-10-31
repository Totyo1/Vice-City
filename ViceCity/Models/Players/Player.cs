using System;
using System.Collections.Generic;
using System.Text;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Models.Players.Contracts;
using ViceCity.Repositories;
using ViceCity.Repositories.Contracts;

namespace ViceCity.Models.Players
{
    public class Player : IPlayer
    {
        private string name;
        private int lifePoints;
        private readonly IRepository<IGun> gunRepository;
        private bool isAlive;

        public Player(string name, int lifePoints)
        {
            this.Name = name;
            this.LifePoints = lifePoints;
            this.gunRepository = new GunRepository();
            this.IsAlive = isAlive;
        }

        public string Name
        {
            get => this.name;
            set
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
            set
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
            get => this.isAlive;
            private set
            {
                if (this.lifePoints <= 0)
                {
                    this.isAlive = false;
                }
                else
                {
                    this.isAlive = true;
                }
            }
        }

        public IRepository<IGun> GunRepository { get; set; }

        public void TakeLifePoints(int points)
        {
            this.LifePoints -= points;
        }
    }
}
