using Data.BaseEnum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsWebApi.Application.DataTransferObject
{
    public class PhoneDto
    {
        public PhoneType PhoneType { get; set; }
        public string PhoneNumber { get; set; }
    }
}
