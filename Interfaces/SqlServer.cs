using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class SqlServer : IDbms
    {
        public string SqlLanguage { get;set; }
        public string DbInstance { get; set;}
        public string QuerySchema { get; set; }
        public string LicenseKey { get; } = Guid.NewGuid().ToString();

        public bool CreateDb(string Name)
        {
            Console.WriteLine("db CREATED");
            return true;
        }

        public bool DeleteDb(string Name)
        {
            Console.WriteLine("db DELETED");
            return true;
        }

        public string AddNewQuery()
        {
            return "insert into ....";
        }
    }
}
