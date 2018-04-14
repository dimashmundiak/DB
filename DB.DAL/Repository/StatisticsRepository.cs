using Dapper;
using DB.DAL.Enteties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace DB.DAL.Repository
{
    public class StatisticsRepository : Session<Statistics>
    {
        public override List<Statistics> Select()
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                return db.Query<Statistics>("SELECT * FROM [Statistics]").ToList();
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
