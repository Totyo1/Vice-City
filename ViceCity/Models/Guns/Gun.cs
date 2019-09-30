using System;
using System.Collections.Generic;
using System.Text;
using ViceCity.Models.Guns.Contracts;

namespace ViceCity.Models.Guns
{
    public abstract class Gun : IGun
    {
        private string name;
        private int bulletsPerBarrel;
        private int totalBullets;
        private int barelCapacity;
        private bool canFire;

        public Gun(string name, int bulletsPerBarrel, int totalBullets)
        {
            this.Name = name;
            this.BulletsPerBarrel = bulletsPerBarrel;
            this.TotalBullets = totalBullets;
            this.CanFire = canFire;
            this.barelCapacity = bulletsPerBarrel;
        }

        public string Name
        {
            get => this.name;
            private set
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
            protected set
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
            get => totalBullets;
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Total bullets cannot be below zero!");
                }
                this.totalBullets = value;
            }
        }

        public bool CanFire
        {
            get => this.CanFire;
            protected set
            {
                if (this.bulletsPerBarrel > 0)
                {
                    value = true;
                }
                else
                {
                    value = false;
                }
            }
        }
        public int BarelCapacity { get; }

        public virtual int Fire()
        {
            if (canFire == false)
            {
                if (totalBullets > 0)
                {
                    this.bulletsPerBarrel += barelCapacity;
                    this.totalBullets -= barelCapacity;
                }
                else
                {
                    return 0;
                }
            }
            bulletsPerBarrel--;
            return 1;
        }
    }
}
