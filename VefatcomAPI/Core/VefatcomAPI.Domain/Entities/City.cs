using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VefatcomAPI.Domain.Entities.Common;

namespace VefatcomAPI.Domain.Entities
{
    public class City : BaseEntity
    {
        public string CityName { get; set; }

        public IQueryable<Dead> Deads { get; set; }

    }
}
