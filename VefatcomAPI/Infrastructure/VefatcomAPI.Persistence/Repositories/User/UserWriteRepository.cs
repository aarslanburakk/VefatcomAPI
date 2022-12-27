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
    public class UserWriteRepository : WriteRepository<User>, IUserWriteRepository
    {
        public UserWriteRepository(VefatcomAPIDbContext context) : base(context)
        {
        }
    }
}
