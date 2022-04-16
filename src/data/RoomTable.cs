using System;
using System.Collections.Generic;

public class RoomTable : Table
{
    public Room GetByRoomID(int roomID)
    {
        var r = records.Find(rec =>
        {
            Room room = (Room)rec;
            return room.roomID == roomID;
        } );
        if (r == null) throw new ArgumentException("No such roomID exists");
        return (Room)r;
    }

    public void Add(int roomID, int price, int maxTenants)
    {
        base.Add(new Room(roomID, price, maxTenants));
    }
}
