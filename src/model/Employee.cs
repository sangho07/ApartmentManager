public class Employee : Person
{
    private int salary;
    private string role;

    public Employee(int id, string name, int age, bool gender, string ssn, int salary, string role) : base(id, name, age, gender, ssn)
    {
        this.salary = salary;
        this.role = role;
    }

    public override string ToString()
    {
        return base.ToString() + "salary {salary} | role {role}";
    }
}