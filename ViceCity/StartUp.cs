using ViceCity.Core;
using ViceCity.Core.Contracts;
using System;
using ViceCity.Models.Guns;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Models.Players;

namespace ViceCity
{
    public class StartUp
    {
        
        public static void Main(string[] args)
        {

            var gun = new Pistol("asd");
         
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    gun.Fire();
                }
            }
           
            Console.WriteLine(gun.CanFire);
            Console.WriteLine(gun.BulletsPerBarrel);
            Console.WriteLine(gun.TotalBullets);

            var player = new MainPlayer();
           
            player.TakeLifePoints(10);
            Console.WriteLine(player.IsAlive);
            Console.WriteLine(player.LifePoints);

        }
    }
}
