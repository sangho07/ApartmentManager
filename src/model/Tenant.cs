public class Tenant : Person
{
    private int roomID;

    public Tenant(int id, string name, int age, bool gender, string ssn, int roomID) : base(id, name, age, gender, ssn)
    {
        this.roomID = roomID;
    }

    public override string ToString()
    {
        return base.ToString() + $"roomID {roomID}";
    }
}