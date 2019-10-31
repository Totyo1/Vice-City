using System;
using System.Collections.Generic;
using System.Text;

namespace ViceCity.Models.Guns.Contracts
{
    public class Rifle : Gun
    {
        private const int initialBulletsPerBarel = 50;
        private const int initialTotalBullets = 500;

        public Rifle(string name) : base(name, initialBulletsPerBarel, initialTotalBullets)
        {
        }

        public override int Fire()
        {
            if (CanFire)
            {
                if (this.BulletsPerBarrel == 0)
                {
                    TotalBullets -= initialBulletsPerBarel;
                    BulletsPerBarrel = initialBulletsPerBarel;
                }
                this.BulletsPerBarrel -= 5;

                return 5;
            }
            else { return 0; }
        }
    }
}
