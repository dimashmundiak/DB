using System;

namespace DB.DAL.Enteties
{
    public class Client
    {
        public string Second_Name { get; set; }
        public string First_Name { get; set; }
        public string Father_Name { get; set; }
        public char Gender { get; set; }
        public DateTime Birth_Date { get; set; }
        public string Phone_Number { get; set; }
        public string Status { get; set; }
        public int Count_Of_Marriage { get; set; }
        public int Count_Of_Children { get; set; }
        public string Bad_Habit { get; set; }
        public int Age { get; set; }
    }
}
