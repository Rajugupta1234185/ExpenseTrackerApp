using SQLite;

public class MyModel // MyModel class Holds user info:
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    public string Name { get; set; }
    public string Password { get; set; }

    public string Contact { get; set; }

    public string Image {  get; set; }

}

//For storing Transactions details in Sqlite !!!

public class Transaction
{
    public DateTime Date { get; set; }

    public string Type { get; set; }

    public int Amount { get; set; }

    public string Notes { get; set; }

    public string Tags { get; set; }
}