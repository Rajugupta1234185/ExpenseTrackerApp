using SQLite;

public class MyModel
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    public string Name { get; set; }
    public string Password { get; set; }

    public string Contact { get; set; }

    public string Image {  get; set; }

}
