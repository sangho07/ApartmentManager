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
        if (ssn.Length == 12 && Int64.TryParse(ssn, out Int64 i)) this.ssn = ssn;
        else throw new ArgumentException("SSN must be 12 character long and numeric");
    }


    public override string ToString()
    {
        return $"name {name} | age {age} | gender {(gender ? "Nam" : "Nữ")} | ssn {ssn} | ";
    }
}