using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthenaHacks18.Models.Request
{
    public class StudentUpdateRequest : StudentCreateRequest
    {
        [Required]
        public int Id { get; set; }
    }
}
