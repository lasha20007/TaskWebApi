using Microsoft.AspNetCore.Http;
using PersonsWebApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsWebApi.Application.Interfaces
{
    public interface IPhotoService
    {
        Task<IFormFile> AddPhotoOfPerson(PersonPhoto model);
        Task<string> GetPhotoByPersonId(int personId);
        Task DeletePhotoOfPerson(int personId);
        Task<IFormFile> UpdatePhotoOfPerson(PersonPhoto model);
    }
}
