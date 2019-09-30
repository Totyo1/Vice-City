using System;
using System.Collections.Generic;
using System.Text;

namespace ViceCity.Models.Guns
{
    class Pistol : Gun
    {
        private static int InitialBulletsPerBarrel = 10;
        private static int InitialTotalBullets = 100;

        public Pistol(string name) : base(name, InitialBulletsPerBarrel, InitialTotalBullets)
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
