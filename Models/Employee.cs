namespace EmployeeRigistration.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? FatherName { get; set; }

        public string? CompanyName { get; set; }
        public int? Age { get; set; }
        public int ContactNo { get; set; }
        public string? Email { get; set; }
        public string? Gender { get; set; }
        public string? Nationality { get; set; }
        public int AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? Domain { get; set; }
        public int Salary { get; set; }
        

    }
}