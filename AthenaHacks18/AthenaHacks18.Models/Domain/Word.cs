using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthenaHacks18.Models.Domain
{
    public class Word
    {
        public string WordName { get; set; }
        public int? GradeLevel { get; set; }
        public string PartsOfSpeech { get; set; }
        public string Definition { get; set; }
        public string Example { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
