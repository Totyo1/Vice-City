using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Repositories.Contracts;

namespace ViceCity.Repositories
{
    public class GunRepository : IRepository<IGun>
    {
        private readonly IDictionary<string, IGun> guns;

        public IReadOnlyCollection<IGun> Models => this.guns.Values.ToList().AsReadOnly();

        public void Add(IGun model)
        {
            if (this.guns.ContainsKey(model.Name))
            {
                return;
            }
            this.guns[model.Name] = model;
        }

        public IGun Find(string name)
        {
            return this.GetByName(name);
        }

        public bool Remove(IGun model)
        {
            var gun = this.GetByName(model.Name);
            if (gun == null)
            {
                return false;
            }
            this.guns.Remove(model.Name);

            return true;
        }

        private IGun GetByName (string name)
        {
            if (!this.guns.ContainsKey(name))
            {
                return null;
            }

            return this.guns[name];
        }
    }
}
