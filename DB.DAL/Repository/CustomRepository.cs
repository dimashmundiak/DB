using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DB.DAL.DTO;
using DB.DAL.Enteties;

namespace DB.DAL.Repository
{
    public class CustomRepository : Session<Custom>
    {
        public override List<Custom> Select()
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                return db.Query<Custom>("SELECT * FROM Custom").ToList();
            }
        }

        public List<CustomDto> SelectSecondQuery(string endDate, string secondName, string firstName, string fatherName)
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                return db.Query<CustomDto>(
                        $"SELECT c.service_id, c.start_date, c.end_date FROM Custom c LEFT JOIN Client cl on c.client_father_name = cl.father_name AND c.client_first_name = cl.first_name AND c.client_second_name = cl.second_name WHERE c.client_second_name = '{secondName}' AND c.client_first_name = '{firstName}' AND c.client_father_name = '{fatherName}' AND c.start_date <= '{endDate}'")
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
