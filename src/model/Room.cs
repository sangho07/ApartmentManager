public class Room : IRecord
{
    public int roomID { get; } // Unique
    private int price;
    private int maxTenants;
    private int currentTenants;


    public void incrementTenant()
    {
        if (currentTenants < maxTenants) currentTenants++;
    }

    public Room(int roomID, int price, int maxTenants)
    {
        this.roomID = roomID;
        this.price = price;
        this.maxTenants = maxTenants;
    }

    public override string ToString()
    {
        return $"roomID {roomID} | price {price} | maxTenants {maxTenants} | currentTenants {currentTenants}";
    }
}