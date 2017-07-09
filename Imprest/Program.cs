using Imprest.Models.Imprest.CoreEntity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imprest
{
    class Program
    {
       public  static Model1 db = new Model1();
        static void Main(string[] args)
        {
            string sqlscript = File.ReadAllText(@"D:\imp\Imprest\Imprest.Models\sqltext\insert.txt");
            db.Database.ExecuteSqlCommand(sqlscript);
            sqlscript = File.ReadAllText(@"D:\imp\Imprest\Imprest.Models\sqltext\vouchertypesql.txt");
            db.Database.ExecuteSqlCommand(sqlscript);
            sqlscript = File.ReadAllText(@"D:\imp\Imprest\Imprest.Models\sqltext\AccountStatementMasterDelete.txt");
            db.Database.ExecuteSqlCommand(sqlscript);
            sqlscript = File.ReadAllText(@"D:\imp\Imprest\Imprest.Models\sqltext\TransactionMasterDelete.txt");
            db.Database.ExecuteSqlCommand(sqlscript);
        }
      
    }
}
