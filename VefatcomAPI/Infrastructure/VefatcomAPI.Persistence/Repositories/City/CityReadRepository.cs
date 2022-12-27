using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VefatcomAPI.Application.Repositories;
using VefatcomAPI.Domain.Entities;
using VefatcomAPI.Persistence.Contexts;

namespace VefatcomAPI.Persistence.Repositories
{
    public class CityReadRepository : ReadRepository<City>, ICityReadRepository
    {
        public CityReadRepository(VefatcomAPIDbContext context) : base(context)
        {
        }
    }
}
