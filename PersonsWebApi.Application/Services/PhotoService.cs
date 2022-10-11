using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using PersonsWebApi.Application.Interfaces;
using PersonsWebApi.Domain.Entities;
using PersonsWebApi.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsWebApi.Application.Services
{
    public class PhotoService : IPhotoService
    {
        private readonly IHostingEnvironment _env;
        private readonly IPhotoRepository _photo;
        private readonly IPersonRepository _repository;

        public PhotoService(IHostingEnvironment env,
            IPhotoRepository photo,
            IPersonRepository repository)
        {
            _env = env;
            _photo = photo;
            _repository = repository;
        }
        public async Task<IFormFile> AddPhotoOfPerson(PersonPhoto model)
        {
            if (model.Photo != null)
            {
                var uploadsFolder = Path.Combine(_env.WebRootPath, "Images");
                var unique_filename = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                var filePath = Path.Combine(uploadsFolder, unique_filename);
                await model.Photo.CopyToAsync(new FileStream(filePath, FileMode.Create));

                await _photo.AddPhoto(unique_filename, model.PersonId);

                return model.Photo;
            }

            throw new Exception("Photo not found");
        }

        public async Task DeletePhotoOfPerson(int personId)
        {
            var person = await _repository.GetByIdAsync(personId);
            var fullPath = Path.Combine(_env.WebRootPath, "Images\\" + person.PhotoPath);
            if (System.IO.File.Exists(fullPath))
            {
                System.IO.File.Delete(fullPath);
            }

            await _photo.DeletePhoto(personId);
        }

        public async Task<string> GetPhotoByPersonId(int personId)
        {
            var person = await _repository.GetByIdAsync(personId);
            if (!String.IsNullOrEmpty(person.PhotoPath))
            {
                var photoPath = Path.Combine(_env.WebRootPath, "Images\\" + person.PhotoPath);
                return photoPath;
            }

            throw new Exception("Photo not found");
        }

        public async Task<IFormFile> UpdatePhotoOfPerson(PersonPhoto model)
        {
            var person = await _repository.GetByIdAsync(model.PersonId);
            if (model.Photo != null)
            {
                var fullPath = Path.Combine(_env.WebRootPath, "Images\\" + person.PhotoPath);
                if (System.IO.File.Exists(fullPath))
                {
                    System.IO.File.Delete(fullPath);
                }

                await AddPhotoOfPerson(model);

                return model.Photo;
            }

            throw new Exception("Photo not found");
        }
    }
}
