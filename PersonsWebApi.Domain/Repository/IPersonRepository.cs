using Microsoft.AspNetCore.Http;
using PersonsWebApi.Domain.Entities;
using PersonsWebApi.Domain.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsWebApi.Domain.Repository
{
    public interface IPersonRepository : IRepository<Person>
    {
        
    }
}
