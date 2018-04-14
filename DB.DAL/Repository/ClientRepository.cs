using Dapper;
using DB.DAL.DTO;
using DB.DAL.Enteties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace DB.DAL.Repository
{
    public class ClientRepository : Session<Client>
    {
        public override List<Client> Select()
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                return db.Query<Client>("SELECT * FROM Client").ToList();
            }
        }

        public List<ClientDto> SelectFifthQuery(int countMarriage, int countChildren, int bottomAge, int topAge)
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                return db.Query<ClientDto>(
                        $"SELECT c.second_name, c.first_name, c.father_name, c.phone_number, c.age FROM Client c WHERE c.count_of_marriage = {countMarriage} AND c.count_of_children = {countChildren} AND c.age BETWEEN {bottomAge} AND {topAge}")
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
