using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using PersonsWebApi.Domain.BaseEnum;

namespace PersonsWebApi.Domain.Entities
{
    [Table("Person")]
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        [Required]
        [MaxLength(50), MinLength(2)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50), MinLength(2)]
        public string Surname { get; set; }
        public Gender Gender { get; set; }
        [Required]
        public string PersonalNumber { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        public int CityRefId { get; set; }
        public string PhotoPath { get; set; }

    }
}
