using System.Collections.Generic;

namespace DB.DAL.Repository
{
    public abstract class Session<T>
    {

        protected string ConnectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DatingAgency;Integrated Security=True";

        public abstract List<T> Select();
        public abstract int Insert();
        public abstract int Delete();
    }
}
