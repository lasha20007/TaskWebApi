using Data.BaseEnum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsWebApi.Domain.Entities
{
    [Table("Phone")]
    public class Phone
    {
        [Key]
        public int PhoneId { get; set; }
        public int PersonRefId { get; set; }
        public PhoneType PhoneType { get; set; }
        [MaxLength(50), MinLength(4)]
        public string PhoneNumber { get; set; }
    }
}
