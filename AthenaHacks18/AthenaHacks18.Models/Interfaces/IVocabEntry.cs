using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthenaHacks18.Models.Interfaces
{
    public interface IVocabEntry
    {
        int Id { get; set; }
        string Entry { get; set; }
        IEnumerable<string> Definition { get; set; }
    }
}
