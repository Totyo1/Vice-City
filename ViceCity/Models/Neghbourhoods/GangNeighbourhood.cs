using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Models.Neghbourhoods.Contracts;
using ViceCity.Models.Players.Contracts;

namespace ViceCity.Models.Neghbourhoods
{
    class GangNeighbourhood : INeighbourhood
    {

        public void Action(IPlayer mainPlayer, ICollection<IPlayer> civilPlayers)
        {
            IGun currGun = null;
            IPlayer currPlayer = null;
            while (true)
            {
                if (currGun == null || !currGun.CanFire)
                {
                    currGun = mainPlayer.GunRepository[0];
                    mainPlayer.GunRepository.Models.Remove(currGun);
                }
                if (currPlayer == null || !currPlayer.IsAlive)
                {
                    currPlayer = civilPlayers.First();
                    civilPlayers.Remove(currPlayer);
                }

                while (currGun.CanFire && currPlayer.IsAlive)
                {
                    currPlayer.TakeLifePoints(currGun.Fire());
                }
                if (mainPlayer.GunRepository.Models.Count == 0 && !currGun.CanFire)
                {
                    break;
                }
                if (civilPlayers.Count == 0 && currPlayer.IsAlive)
                {
                    break;
                }
            }

            if (mainPlayer.GunRepository.Models.Count == 0)
            {
                
                while ((civilPlayers.Count != 0 && currPlayer.IsAlive) && mainPlayer.IsAlive)
                {

                    currGun = currPlayer.GunRepository.Models[0];
                    currPlayer.GunRepository.Remove(currGun);
                    while (currGun.CanFire && mainPlayer.IsAlive)
                    {
                        mainPlayer.TakeLifePoints(currGun.Fire());
                    }
                    if (!currGun.CanFire)
                    {
                        if (currPlayer.GunRepository.Models.Count != 0)
                        {
                            currGun = currPlayer.GunRepository.Models[0];
                            currPlayer.GunRepository.Remove(currGun);
                        }
                        else
                        {
                            currPlayer = civilPlayers.First();
                            civilPlayers.Remove(currPlayer);
                        }
                        
                    }


                }

            }
        }


    }
}
