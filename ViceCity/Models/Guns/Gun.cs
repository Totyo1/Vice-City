using System;
using System.Collections.Generic;
using System.Text;
using ViceCity.Models.Guns.Contracts;

namespace ViceCity.Models.Guns
{
    class Gun : IGun
    {
        public string Name => throw new NotImplementedException();

        public int BulletsPerBarrel => throw new NotImplementedException();

        public int TotalBullets => throw new NotImplementedException();

        public bool CanFire => throw new NotImplementedException();

        public int Fire()
        {
            throw new NotImplementedException();
        }
    }
}
