using System.Collections.Generic;

public abstract class ATable
{
    private List<IRecord> records;
    protected int lastID;

    public ATable()
    {
        this.records = new List<IRecord>();
        this.lastID = 0;
    }

    public void Add(IRecord rec)
    {
        records.Add(rec);
    }

    public List<IRecord> All()
    {
        return records;
    }

    public IRecord Get(int id)
    {
        return records.Find(entry => entry.id == id);
    }

    public void Delete(int id)
    {
        records.Remove(Get(id));
    }

    public abstract void Update(int id);
}