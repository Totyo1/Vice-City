using System;
using System.Collections.Generic;
using System.Text;

namespace ViceCity.Models.Guns.Contracts
{
   public class Pistol : Gun
    {
        private const int initialBulletsPerBarel = 10;
        private const int initialTotalBullets = 100;


        public Pistol(string name) : base(name, initialBulletsPerBarel, initialTotalBullets)
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
                BulletsPerBarrel--;
                return 1;
            }
            else { return 0;}

        }
    }
}
