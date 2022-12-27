using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VefatcomAPI.Domain.Entities;
using VefatcomAPI.Domain.Entities.Common;

namespace VefatcomAPI.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {

        DbSet<T> Table { get; }

    }
}
