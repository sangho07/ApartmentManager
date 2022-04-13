using System;

public class Program
{
    static void Main()
    {
        Apartment ap = new Apartment("ABC", "ABC 123");

        ap.RoomTable.Add(0100, 32, 3);

        Console.WriteLine("Phòng trống khi chưa đăng ký người ở");
        Console.WriteLine(ap.RoomTable.GetByRoomID(100));

        ap.TenantTable.Add("A", 20, true, "321987654321", 0100);
        ap.TenantTable.Add("B", 19, false, "123456789123", 0100);

        Console.WriteLine("Phòng có 2 người sau khi đăng ký người ở");
        Console.WriteLine(ap.RoomTable.Get(0));

        // Register tenant to invalid room
        // ap.TenantTable.Add("C", 41, false, "123456789012", 2);

        // Test
    }
}