using System;
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
        IRecord rec = records.Find(entry => entry.id == id);
        if (rec == null) throw new ArgumentException($"Can't find that ID, last ID is {lastID}");
        return rec;
    }

    public void Delete(int id)
    {
        records.Remove(Get(id));
    }

    public abstract void Update(int id);
}