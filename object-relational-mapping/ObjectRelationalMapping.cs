using System;

public partial class Orm : IDisposable
{
    private Database _database;

    public Orm(Database database)
    {
        this._database = database;
    }

    public void Begin()
    {
        _database.BeginTransaction();
    }

    public void Write(string data)
    {
        try
        {
            _database.Write(data);
        }
        catch
        {
            Dispose();
        }
    }

    public void Commit()
    {
        try
        {
            _database.EndTransaction();
        }
        catch
        {
            Dispose();
        }
    }

    public void Dispose()
    {
        _database.Dispose();
    }
}
