public class RoomTable : ATable
{
    public override void Update(int id)
    {
        throw new System.NotImplementedException();
    }

    public void Add(int price, int maxTenants)
    {
        base.Add(new Room(lastID++, price, maxTenants));
    }
}