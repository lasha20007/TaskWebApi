using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using PersonsWebApi.Application.DataTransferObject;
using PersonsWebApi.Application.Interfaces;
using PersonsWebApi.Domain.Entities;
using PersonsWebApi.Domain.Paging;
using PersonsWebApi.Domain.Repository;

namespace PersonsWebApi.Application.Services
{
    public class PersonService : IPersonService
    {
        private readonly IMapper _mapper;
        private readonly IPhoneService _phoneService;
        private readonly IPersonRepository _repository;
        public PersonService(IMapper mapper,
            IPersonRepository repository,
            IPhoneService phoneService)
        {
            _mapper = mapper;
            _repository = repository;
            _phoneService = phoneService;
        }

        public async Task<PersonDto> AddAsync(PersonDto entity)
        {
            var personDto = new PersonDto();
            var model = _mapper.Map<Person>(entity);
            _mapper.Map(await _repository.AddAsync(model), personDto);

            return personDto;
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public IList<PersonDto> GetAll(PagingParameters paging)
        {
            var model = new List<PersonDto>();
            var response = _repository.GetAll(paging);
            _mapper.Map(response, model);
            return model;
        }

        public async Task<PersonDto> GetByIdAsync(int id)
        {
            return _mapper.Map<PersonDto>(await _repository.GetByIdAsync(id));
        }

        public async Task<PersonDto> UpdateAsync(PersonDto entity)
        {
            var model = _mapper.Map<Person>(entity);
            return _mapper.Map<PersonDto>(await _repository.UpdateAsync(model));
        }

    }
}
