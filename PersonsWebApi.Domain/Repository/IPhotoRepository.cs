using PersonsWebApi.Domain.Entities;
using PersonsWebApi.Domain.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsWebApi.Domain.Repository
{
    public interface IPhotoRepository : IRepository<PersonPhoto>
    {
        Task AddPhoto(string path, int personId);
        Task DeletePhoto(int personId);
    }
}
