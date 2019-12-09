namespace EmployeeServiceRepository
{
   
    public interface IEmployee
    {
        string FirstName { get; set; }
        string FullName { get; }
        int Id { get; set; }
        string LastName { get; set; }
        decimal Salary { get; set; }
    }
}