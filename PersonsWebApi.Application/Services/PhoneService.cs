using PersonsWebApi.Application.DataTransferObject;
using PersonsWebApi.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsWebApi.Application.Services
{
    public class PhoneService : IPhoneService
    {
        public Task CreatePersonPhones(IList<PhoneDto> phoneDtos)
        {
            foreach (var dto in phoneDtos)
            {
                
            }
            throw new NotImplementedException();
        }
    }
}
