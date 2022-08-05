using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class MongoDb : IDbms
    {
        public string SqlLanguage { get ; set ; }
        public string DbInstance { get; set;  }
        public string QuerySchema { get; set;  }

        public string LicenseKey { get; } = Guid.NewGuid().ToString();
        public bool CreateDb(string Name)
        {
            Console.WriteLine($"new mongo db collection created-{Name}");
            return true;
        }

        public bool DeleteDb(string Name)
        {
            Console.WriteLine($" mongo db collection deleted-{Name}");
            return true;
        }
    }
}
