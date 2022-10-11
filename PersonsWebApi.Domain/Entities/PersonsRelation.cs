using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonsWebApi.Domain.BaseEnum;

namespace PersonsWebApi.Domain.Entities
{
    [Table("PersonsRelation")]
    public class PersonsRelation
    {
        [Key]
        public int Id { get; set; }
        public int From_PersonRefId { get; set; }
        [Required]
        public Relation Relation { get; set; }
        public Person To_PersonRefId { get; set; }

    }
}
