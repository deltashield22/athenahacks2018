using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthenaHacks18.Models.Request
{
    public class WordCreateUpdateRequest
    {
        [Required]
        public string WordName { get; set; }

        [Required]
        public int? GradeLevel { get; set; }

        [Required]
        public string PartsOfSpeech { get; set; }

        public string Definition { get; set; }
        public string Example { get; set; }
    }
}
