using SQLite;

public class DatabaseService
{
    private readonly SQLiteConnection _database;

    public DatabaseService(string dbPath)
    {
        _database = new SQLiteConnection(dbPath);
        _database.CreateTable<MyModel>(); // Replace MyModel with your data model class
    }

    public List<MyModel> GetItems()
    {
        return _database.Table<MyModel>().ToList();
    }

    public int SaveItem(MyModel item)
    {
        return _database.Insert(item);
    }


}
