using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsWebApi.Domain.Entities
{
    public class PersonPhoto
    {
        public int PersonId { get; set; }
        public IFormFile Photo { get; set; }
    }
}
