using System;
using ViceCity.Models.Guns.Contracts;

namespace ViceCity.Models.Guns
{
    public abstract class Gun : IGun
    {
        private string name;
        private int bulletsPerBarrel;
        private int totalBullets;
        private bool canFire;

        public Gun()
        {
        }

        public Gun(string name, int bulletsPerBarrel, int totalBullets)
        {
            this.Name = name;
            this.BulletsPerBarrel = bulletsPerBarrel;
            this.TotalBullets = totalBullets;
            this.CanFire = canFire;
        }
        
        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or a white space!");
                }
                this.name = value;
            }
        }

        public int BulletsPerBarrel
        {
            get => this.bulletsPerBarrel;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Bullets cannot be below zero!");
                }
                this.bulletsPerBarrel = value;
            }
        }

        public int TotalBullets
        {
            get => this.totalBullets;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Total bullets cannot be below zero!");
                }
                else
                {
                    this.totalBullets = value;
                }
            }
        }

        public bool CanFire
        {
            get => this.canFire;
            private set
            {
                if (this.BulletsPerBarrel <= 0)
                {
                    this.canFire = false;
                }
                this.canFire = true;
            }
        }

        public abstract int Fire();
    }
}
