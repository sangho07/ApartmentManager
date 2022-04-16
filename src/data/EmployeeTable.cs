public class EmployeeTable : Table
{
    public void Add(string name, int age, bool gender, string ssn, int workday, string role)
    {
        int salary = workday * 20;
        base.Add(new Employee(name, age, gender, ssn, salary, role));
    }
    public void UpdateRole(int id, string role)
    {
        Employee e = (Employee)base.Get(id);
        e.UpdateRole(role);
    }
    public void UpdateSalary(int id, int workday)
    {
        Employee e = (Employee)base.Get(id);
        e.UpdateSalary(workday);
    }

}