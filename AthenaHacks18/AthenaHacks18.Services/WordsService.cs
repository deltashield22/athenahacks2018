using AthenaHacks2018.Data.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthenaHacks18.Services
{
    public class WordsService
    {
        readonly IDataProvider dataProvider;

        public WordsService(IDataProvider dataProvider)
        {
            this.dataProvider = dataProvider;
        }

    }
}
