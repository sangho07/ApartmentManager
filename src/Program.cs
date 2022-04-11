using System;

public class Program
{
    static void Main()
    {
        Apartment ap = new Apartment("ABC", "ABC 123");

        ap.RoomTable.Add(32, 3);
        Console.WriteLine("Phòng trống khi chưa đăng ký người ở");
        Console.WriteLine(ap.RoomTable.Get(0));

        ap.TenantTable.Add("Fag", 2, true, "242141241", 0);
        ap.TenantTable.Add("Got", 3, false, "79199922", 0);

        // foreach (Tenant t in ap.TenantTable.All())
        // {
        //     Console.WriteLine(t);
        // }

        Console.WriteLine("Phòng có 2 người sau khi đăng ký người ở");
        Console.WriteLine(ap.RoomTable.Get(0));

    }
}