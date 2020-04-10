using System;

namespace WebBase.Models
{
    public class Users
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string Lname { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime RegisterDate { get; set; }

    }
}