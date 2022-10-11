using PersonsWebApi.Application.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsWebApi.Application.Interfaces
{
    public interface IPhoneService
    {
        Task CreatePersonPhones(IList<PhoneDto> phoneDtos);

    }
}
