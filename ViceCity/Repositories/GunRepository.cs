using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Repositories.Contracts;

namespace ViceCity.Repositories
{
    class GunRepository : IRepository<IGun>

    {
        private List<IGun> models;

        public List <IGun> Models { get; set; }
       
 public void Add(IGun model)
        {
            this.models.Add( model);
        }

        public IGun Find(string name)
        {
            return models.Where(m => m.Name.Equals(name)).FirstOrDefault();
        }

        public bool Remove(IGun model)
        {
            this.models.Remove(model);
            return true;
        }
    }
}
