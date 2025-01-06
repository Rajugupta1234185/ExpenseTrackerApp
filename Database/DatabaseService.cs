using SQLite;
using System;
using System.Collections.Generic;

public class DatabaseService    // This class is used for manipulating data in and from database
{
    private readonly SQLiteConnection _database;

    public DatabaseService(string dbPath)
    {
        _database = new SQLiteConnection(dbPath);
        _database.CreateTable<MyModel>();  // Creating the table for MyModel
        _database.CreateTable<Transaction>();  // Creating the table for Transaction
    }

    // MyModel methods

    public List<MyModel> GetItems()
    {
        return _database.Table<MyModel>().ToList();
    }

    public int SaveItem(MyModel item)
    {
        return _database.Insert(item);
    }

    // Transaction methods

    // Method to retrieve all transactions
    public List<Transaction> GetTransactions()
    {
        return _database.Table<Transaction>().ToList();
    }

    // Method to add a new transaction
    public int SaveTransaction(Transaction transaction)
    {
        return _database.Insert(transaction);
    }

    // Method to update an existing transaction (if needed)
    public int UpdateTransaction(Transaction transaction)
    {
        return _database.Update(transaction);
    }

    // Method to delete a transaction
    public int DeleteTransaction(Transaction transaction)
    {
        return _database.Delete(transaction);
    }
}
