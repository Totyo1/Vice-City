﻿namespace ViceCity.Core.Contracts
{
    public  interface IController
    {
        string AddPlayer(string name);

        string AddGun(string type, string name);

        string AddGunToPlayer(string name);

        string Fight();
    }
}
