using System;
using System.Collections.Generic;
using System.Text;

namespace ViceCity.Models.Guns
{
    class Pistol : Gun
    {
        public Pistol(string name, int bulletsPerBarrel, int totalBullets) : base(name, bulletsPerBarrel, totalBullets)
        {
        }

         public override int Fire()
        {
            if (CanFire == false)
            {
                if (TotalBullets > 0)
                {
                    this.BulletsPerBarrel += BarelCapacity;
                    this.TotalBullets -= BarelCapacity;
                }
                else
                {
                    return 0;
                }
            }
            BulletsPerBarrel--;
            return 1;
        }
    }
}
