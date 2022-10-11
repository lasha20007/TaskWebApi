using Microsoft.AspNetCore.Http;
using PersonsWebApi.Domain.Entities;
using PersonsWebApi.Domain.Repository;
using PersonsWebApi.Infrastructure.Data;
using PersonsWebApi.Infrastructure.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsWebApi.Infrastructure.Repository
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(RepositoryContext context) : base(context)
        {

        }

    }
}
