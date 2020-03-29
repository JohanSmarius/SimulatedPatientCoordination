using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Assignment
    {
        public int Id { get; set; }

        public string  Name { get; set; }

        public DateTime PlayDate { get; set; }

        public DateTime EndTime { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public List<AssignmentInstructor> AssignedInstructors { get; set; }

        public List<SimulatedPatient> SimulatedPatients { get; set; } = new List<SimulatedPatient>();
    }
}
