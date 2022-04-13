public class Employee : Person
{
    private int salary;
    private string role;

    public Employee(string name, int age, bool gender, string ssn, int salary, string role) : base(name, age, gender, ssn)
    {
        this.salary = salary;
        this.role = role;
    }

    public override string ToString()
    {
        return base.ToString() + "salary {salary} | role {role}";
    }
}