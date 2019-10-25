﻿using System;
using System.Collections.Generic;
using System.Text;
using ViceCity.Models.Guns.Contracts;

namespace ViceCity.Models.Guns
{
    class Gun : IGun
    {
        private string name;
        private int bulletsPerBarrel;
        private int totalBullets;
        private bool canFire;

        public Gun(string name, int bulletsPerBarrel, int totalBullets)
        {
            this.Name = name;
            this.BulletsPerBarrel = bulletsPerBarrel;
            this.TotalBullets = totalBullets;
            
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
                name = value;
            }

        }

        public int BulletsPerBarrel
        {
            get => bulletsPerBarrel;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Bullets cannot be below zero!");
                }
                bulletsPerBarrel = value;
            }
        }

        public int TotalBullets
        {
            get => totalBullets;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Total bullets cannot be below zero!");
                }
                totalBullets = value;
            }
        }

        public bool CanFire
        {
            get => canFire;
            set
            {
                value = bulletsPerBarrel == 0 && totalBullets == 0 ? false : true;

            }
        }

        public virtual int Fire()
        {
            throw new NotImplementedException();
        }
    }
}
