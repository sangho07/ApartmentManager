public class Room : IRecord
{
    public int id { get; }
    private int price;
    private int maxTenants;
    private int currentTenants;

    public void incrementTenant()
    {
        if (currentTenants < maxTenants) currentTenants++;
    }

    public Room(int id, int price, int maxTenants)
    {
        this.id = id;
        this.price = price;
        this.maxTenants = maxTenants;
    }

    public override string ToString()
    {
        return $"id {id} | price {price} | maxTenants {maxTenants}\t| currentTenants {currentTenants}";
    }
}