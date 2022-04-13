public class EmployeeTable : ATable
{
    public override void Update(int id)
    {
        throw new System.NotImplementedException();
    }

    public void Add(string name, int age, bool gender, string ssn, int salary, string role)
    {
        base.Add(new Employee(name, age, gender, ssn, salary, role));
    }
}