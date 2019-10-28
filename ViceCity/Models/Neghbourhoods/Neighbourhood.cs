using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Models.Neghbourhoods.Contracts;
using ViceCity.Models.Players.Contracts;

namespace ViceCity.Models.Neghbourhoods
{
    class Neighbourhood : INeighbourhood
    {

        public void Action(IPlayer mainPlayer, ICollection<IPlayer> civilPlayers)
        {
            while (mainPlayer.GunRepository.Models.Count != 0 && civilPlayers.Count != 0)
            {
                var currGun = mainPlayer.GunRepository.Models[0];
                mainPlayer.GunRepository.Models.Remove(currGun);
                var currPlayer = civilPlayers.First();
                civilPlayers.Remove(currPlayer);


                while (currGun.CanFire && currPlayer.IsAlive)
                {

                    currPlayer.TakeLifePoints(currGun.Fire());
                }

            }
        }
    }
}
