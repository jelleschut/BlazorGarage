using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IOwnerRepository : IGenericRepository<Owner>, IAsyncGenericRepository<Owner>
    {
    }
}
