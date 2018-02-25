using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthenaHacks18.Models.Domain
{
    public class UserBase : IUserAuthData
    {
        public int Id
        {
            get;set;
        }

        public string Name
        {
            get; set;
        }

        public List<string> Roles
        {
            get; set;
        }
    }
}
