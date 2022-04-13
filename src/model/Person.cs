using System;

public class Person : IRecord
{
    private string name;
    private int age;
    private bool gender; // true = Male, false = Female
    private string ssn; // Unique

    public Person(string name, int age, bool gender, string ssn)
    {
        this.name = name;
        this.age = age;
        this.gender = gender;
        this.ssn = ssn;
    }

    public override string ToString()
    {
        return $"name {name} | age {age} | gender {(gender ? "Nam" : "Nữ")} | ssn {ssn} | ";
    }
}