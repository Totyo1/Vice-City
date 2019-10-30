
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Models.Players;
using ViceCity.Models.Players.Contracts;

namespace ViceCity.Core.Contracts
{
    class Controller : IController
    {
        private Queue<IGun> guns;
        private Dictionary<string, IPlayer> civilPlayers;

        private MainPlayer mainPlayer;
 
        public Controller()
        {
            mainPlayer = new MainPlayer();
        }

        public string AddGun(string type, string name)
        {
            if (type != "Pistol" && type != "Rifle" )
            {
                return "Invalid gun type!";
            }
            else
            {
                if (type == "Pistol")
                {
                    var gun = new Pistol(name);
                    guns.Enqueue(gun);
                }
                else
                {
                    var gun = new Rifle(name);
                    guns.Enqueue(gun);
                }
                return $"Successfully added {name} of type: {type}";
            }
        }

        public string AddGunToPlayer(string name)
        {
            if (guns.Count == 0)
            {
                return $"There are no guns in the queue!";
            }
            if (name == "Vercetti")
            {
                mainPlayer.GunRepository.Add(guns.Dequeue());
                return $"Successfully added {mainPlayer.GunRepository.Models[mainPlayer.GunRepository.Models.Count -1].Name} to the Main Player: Tommy Vercetti";
            }
            if (!civilPlayers.ContainsKey(name))
            {
                return $"Civil player with that name doesn't exists!";
            }
            civilPlayers[name].GunRepository.Add(guns.Dequeue());
            return $"Successfully added {civilPlayers[name].GunRepository.Models[civilPlayers[name].GunRepository.Models.Count -1].Name} to the Civil Player: {name}";
        }

        public string AddPlayer(string name)
        {
            var player = new CivilPlayer(name);
            civilPlayers.Add(player.Name, player);
            return $"Successfully added civil player: {name}!";
        }

        public string Fight()
        {
            throw new NotImplementedException();
        }
    }
}
