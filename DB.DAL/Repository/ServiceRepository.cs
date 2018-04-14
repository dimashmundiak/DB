using Dapper;
using DB.DAL.Enteties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using DB.DAL.DTO;

namespace DB.DAL.Repository
{
    public class ServiceRepository : Session<Service>
    {
        public override List<Service> Select()
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                return db.Query<Service>("SELECT * FROM Service").ToList();
            }
        }

        public List<ServiceDto> SelectFirstQuery(float price, string secondName, string firstName, string fatherName)
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                return db.Query<ServiceDto>(
                        $"SELECT s.name, s.price FROM Service s INNER JOIN Custom c on s.name = c.service_id WHERE s.price > {price} AND c.employee_second_name = '{secondName}' AND c.employee_first_name = '{firstName}' AND c.employee_father_name = '{fatherName}'")
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
