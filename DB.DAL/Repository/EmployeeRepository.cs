using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DB.DAL.Enteties;

namespace DB.DAL.Repository
{
    public class EmployeeRepository : Session<Employee>
    {
        public override List<Employee> Select()
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                return db.Query<Employee>("SELECT * FROM Employee").ToList();
            }
        }

        public override int Insert()
        {
            throw new NotImplementedException();
        }

        public override int Delete()
        {
            throw new NotImplementedException();
        }
    }
}
