using System;
using System.Collections.Generic;

namespace VueFridayTest.Models
{
    public class Data
    {
        public IEnumerable<Users> User { get; set; }
    }

    public class Users 
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public DateTime Birthday { get; set; }

        public string Gender { get; set; }

        public string Status { get; set; }

        public string Location { get; set; }
    }
}
