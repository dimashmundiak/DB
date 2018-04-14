using Dapper;
using DB.DAL.Enteties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using DB.DAL.DTO;

namespace DB.DAL.Repository
{
    public class ArchiveRepository:Session<Archive>
    {
        public override List<Archive> Select()
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                return db.Query<Archive>("SELECT * FROM Archive").ToList();
            }
        }

        public List<ArchiveDto> SelectFourthQuery(int age, string status, string gender)
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                return db.Query<ArchiveDto>(
                        $"SELECT c.second_name, c.first_name, c.father_name, c.age, a.archive_date FROM Archive a LEFT JOIN Client c on a.client_second_name = c.second_name AND a.client_first_name = c.first_name AND a.client_father_name = c.father_name WHERE c.age > {age} AND c.status = '{status}' AND c.gender = '{gender}'")
                    .ToList();
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
