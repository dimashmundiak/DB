using Dapper;
using DB.DAL.DTO;
using DB.DAL.Enteties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace DB.DAL.Repository
{
    public class DepartmentRepository : Session<Department>
    {
        public override List<Department> Select()
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                return db.Query<Department>("SELECT * FROM Department").ToList();
            }
        }

        public List<DepartmentDto> SelectThirdQuery(string city, string secondName)
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                return db.Query<DepartmentDto>(
                        $"SELECT d.department_number, d.city, d.address, d.phone_number FROM Department d WHERE d.director LIKE '{secondName}%' AND d.city = '{city}'")
                    .ToList();
            }
        }

        public List<CountDto> SelectSixthQuery(int dayCount, string date)
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                return db.Query<CountDto>(
                        $"SELECT e.department_id, count(c.order_number) as count FROM Custom c LEFT JOIN Employee e on c.employee_second_name = e.second_name AND c.employee_first_name = e.first_name AND c.employee_father_name = e.father_name LEFT JOIN Department d on d.department_number = e.department_id left join Client cl on c.client_second_name = cl.second_name AND c.client_first_name = cl.first_name AND c.client_father_name = cl.father_name where c.day_count < {dayCount} and cl.birth_date >= '{date}' group by e.department_id, d.city, d.department_number, cl.birth_date")
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
