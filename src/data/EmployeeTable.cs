public class EmployeeTable : Table
{
    public void Add(string name, int age, bool gender, string ssn, int salary, string role)
    {
        base.Add(new Employee(name, age, gender, ssn, salary, role));
    }
}