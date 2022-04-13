using System;

public class Person : IRecord
{
    public int id { get; }
    protected string name;
    protected int age;
    protected bool gender; // true = Male, false = Female
    protected string ssn;

    public Person(int id, string name, int age, bool gender, string ssn)
    {
        this.id = id;
        this.name = name;
        this.age = age;
        this.gender = gender;
        this.ssn = ssn;
    }

    public override string ToString()
    {
        return $"id {id}| name {name} | age {age} | gender {(gender ? "Nam" : "Nữ")} | ssn {ssn} | ";
    }
}