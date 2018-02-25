using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthenaHacks18.Models
{
    public interface IUserAuthData
    {
        int Id { get; }
        string Name { get; }
        List<string> Roles { get; }
    }
}
