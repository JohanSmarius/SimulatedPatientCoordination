namespace Domain
{
    public class AssignmentInstructor
    {
        public int AssignmentId { get; set; }

        public int InstructorId { get; set; }

        public Assignment Assignment { get; set; }

        public Instructor Instructor { get; set; }
    }
}