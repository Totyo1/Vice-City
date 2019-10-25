using System;
using System.Collections.Generic;
using System.Text;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Models.Players.Contracts;
using ViceCity.Repositories.Contracts;

namespace ViceCity.Models.Players
{
    class Player : IPlayer
    {
        private string name;
        private int ligepoints;
        private IGunRepository<Gun> gunRepository;

        

        public string Name => throw new NotImplementedException();

        public bool IsAlive => throw new NotImplementedException();

        public IRepository<IGun> GunRepository => throw new NotImplementedException();

        public int LifePoints => throw new NotImplementedException();

        public void TakeLifePoints(int points)
        {
            throw new NotImplementedException();
        }
    }
}
