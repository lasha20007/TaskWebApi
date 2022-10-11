using Microsoft.AspNetCore.Http;
using Microsoft.VisualBasic;
using PersonsWebApi.Domain.BaseEnum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PersonsWebApi.Application.DataTransferObject
{
    public class PersonDto
    {
        public int? PersonId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Gender Gender { get; set; }
        public string PersonalNumber { get; set; }
        [NotMapped]
        public DateTime BirthDate { get; set; }
        public int CityRefId { get; set; }
        public IList<PhoneDto> Phone { get; set; }
        public string PhotoPath { get; set; }

    }
}
