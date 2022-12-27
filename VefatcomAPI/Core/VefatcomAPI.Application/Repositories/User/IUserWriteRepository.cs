using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VefatcomAPI.Domain.Entities;

namespace VefatcomAPI.Application.Repositories
{
    public interface IUserWriteRepository : IWriteRepository<User>
    {
    }
}
