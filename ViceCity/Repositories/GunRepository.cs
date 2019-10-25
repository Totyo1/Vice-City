using System;
using System.Collections.Generic;
using System.Text;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Repositories.Contracts;

namespace ViceCity.Repositories
{
    class GunRepository : IRepository<IGun>

    {
        private Dictionary<string, IGun> models;



        public IReadOnlyCollection<IGun> Models => throw new NotImplementedException();

        public void Add(IGun model)
        {
            this.models.Add(model.Name, model);
        }

        public IGun Find(string name)
        {
            return this.models[name];
        }

        public bool Remove(IGun model)
        {
            this.models.Remove(model.Name);
            return true;
        }
    }
}
