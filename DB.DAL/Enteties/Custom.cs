using System;

namespace DB.DAL.Enteties
{
    public class Custom
    {
        public int Order_Number { get; set; }
        public string Service_Id { get; set; }
        public string Service_Partner { get; set; }
        public string Employee_Second_Name { get; set; }
        public string Employee_First_Name { get; set; }
        public string Employee_Father_Name { get; set; }
        public string Client_Second_Name { get; set; }
        public string Client_First_Name { get; set; }
        public string Client_Father_Name { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        public int Day_Count { get; set; }

    }
}
