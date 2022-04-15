using System;
using System.Collections.Generic;

public class Table
{
    protected List<IRecord> records;

    public Table()
    {
        this.records = new List<IRecord>();
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
        return records[id];
    }

    public void Delete(int id)
    {
        records.Remove(Get(id));
    }
}