public class Apartment
{
    private string name;
    private string address;

    private TenantTable tenantTable;
    public TenantTable TenantTable { get => tenantTable; }
    private EmployeeTable employeeTable;
    public EmployeeTable EmployeeTable { get => employeeTable; }
    private RoomTable roomTable;
    public RoomTable RoomTable { get => roomTable; }

    public Apartment(string name, string address)
    {
        this.name = name;
        this.address = address;
        this.roomTable = new RoomTable();
        this.tenantTable = new TenantTable(roomTable);
        this.employeeTable = new EmployeeTable();
    }
}