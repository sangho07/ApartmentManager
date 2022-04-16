public class Employee : Person
{
    private int salary;
    private string role;
    private int workday;


    public Employee(string name, int age, bool gender, string ssn, int workday, string role) : base(name, age, gender, ssn)
    {
        this.workday = workday;
        this.salary = workday * 20;
        this.role = role;
    }
    public void UpdateRole(string role)
    {
        this.role = role;
    }
    public void UpdateSalary(int workday)
    {
        this.salary = workday * 20;
    }


    public override string ToString()
    {
        return base.ToString() + "salary {salary} | role {role}";
    }
}