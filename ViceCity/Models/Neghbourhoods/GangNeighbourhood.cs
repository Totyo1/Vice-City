using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Models.Neghbourhoods.Contracts;
using ViceCity.Models.Players.Contracts;

namespace ViceCity.Models.Neghbourhoods
{
    public class GangNeighbourhood : INeighbourhood
    {

        public void Action(IPlayer mainPlayer, ICollection<IPlayer> civilPlayers)
        {
            IGun currGun = mainPlayer.GunRepository.Models.First();
            IPlayer currPlayer = civilPlayers.First();

            while ((mainPlayer.GunRepository.Models.Count != 0 && currGun.CanFire) ||
                    (civilPlayers.Count != 0 && !currPlayer.IsAlive))
            {
                if (!currGun.CanFire)
                {
                    currGun = mainPlayer.GunRepository.Models.First();
                    mainPlayer.GunRepository.Remove(currGun);
                }

                if (!currPlayer.IsAlive)
                {
                    currPlayer = civilPlayers.First();
                    civilPlayers.Remove(currPlayer);
                }

                while (currPlayer.IsAlive && currGun.CanFire)
                {
                    currPlayer.TakeLifePoints(currGun.Fire());
                }
            }
            if (currPlayer.IsAlive)
            {
                while (civilPlayers.Count != 0 && currPlayer.GunRepository.Models.Count != 0 && !mainPlayer.IsAlive)
                {
                    while (currPlayer.GunRepository.Models.Count != 0 || !mainPlayer.IsAlive)
                    {
                        currGun = currPlayer.GunRepository.Models.First();
                        currPlayer.GunRepository.Remove(currGun);
                        while (!mainPlayer.IsAlive || !currGun.CanFire)
                        {
                            mainPlayer.TakeLifePoints(currGun.Fire());
                        }
                    }

                }
            }

        }
    }
}
