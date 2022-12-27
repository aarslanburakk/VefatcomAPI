using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VefatcomAPI.Domain.Entities.Common;

namespace VefatcomAPI.Domain.Entities
{
    public class User :BaseEntity
    {
        public string UserName { get; set; }
        public string UserLastName { get; set; }
      
        public string UserPassword { get; set; }

        public IQueryable<Dead> Deads { get; set; }


    }
}
