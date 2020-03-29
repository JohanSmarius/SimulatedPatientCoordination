using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ContactPerson { get; set; }

        public string PhoneNumber { get; set; }

        public List<Assignment> Assignments { get; set; }
    }
}
