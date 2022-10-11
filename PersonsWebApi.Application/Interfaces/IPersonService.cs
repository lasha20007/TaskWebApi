using PersonsWebApi.Application.DataTransferObject;
using PersonsWebApi.Domain.Paging;

namespace PersonsWebApi.Application.Interfaces
{
    public interface IPersonService
    {
        IList<PersonDto> GetAll(PagingParameters paging);
        Task<PersonDto> GetByIdAsync(int id);
        Task<PersonDto> AddAsync(PersonDto entity);
        Task<PersonDto> UpdateAsync(PersonDto entity);
        Task DeleteAsync(int id);
    }
}
