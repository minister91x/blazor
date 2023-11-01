
namespace ConsoleApp2
{
    public record struct Employee
    {
        public string EmployeeId { get; init; }
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string Designation { get; set; }
    }
}
