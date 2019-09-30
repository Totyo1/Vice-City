using System;
using System.Collections.Generic;
using System.Text;

namespace ViceCity.Models.Guns
{
    class Rifle : Gun
    {
        private static int InitialBulletsPerBarrel = 50;
        private static int InitialTotalBullets = 500;

        public Rifle(string name) : base(name, InitialBulletsPerBarrel, InitialTotalBullets)
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
            BulletsPerBarrel -= 5;
            return 5;
        }
    }
}
