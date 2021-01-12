using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Services.Interfaces
{
    public interface IOwnerService
    {
        Task Add(Owner owner);
        Task Update(Owner owner);
        Task<Owner> Find(int id);
        Task<IEnumerable<Owner>> GetAll();
        Owner EncryptOwner(Owner owner);
        Owner DecryptOwner(Owner owner);
    }
}
