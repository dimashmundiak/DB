using System;

namespace DB.DAL.Enteties
{
    public class Statistics
    {
        public string Male_Second_Name { get; set; }
        public string Male_First_Name { get; set; }
        public string Male_Father_Name { get; set; }
        public string Female_Second_Name { get; set; }
        public string Female_First_Name { get; set; }
        public string Female_Father_Name { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        public string Status { get; set; }
    }
}
