using System;

public class TenantTable : ATable
{
    private RoomTable roomTable;

    public TenantTable(RoomTable roomTable)
    {
        this.roomTable = roomTable;
    }
    public override void Update(int id)
    {
        throw new NotImplementedException();
    }

    public void Add(string name, int age, bool gender, string ssn, int roomID)
    {
        Room room = roomTable.GetByRoomID(roomID);
        room.incrementTenant();
        base.Add(new Tenant(name, age, gender, ssn, roomID));
    }
}
