using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using SuiviBourse.Model;

namespace SuiviBourse.DataSource
{
    public class AlerteBourseDB
    {
        readonly SQLiteAsyncConnection database;


        public AlerteBourseDB(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            // creation if needed 
            // upgrade table : https://www.codeproject.com/Articles/792883/Using-Sqlite-in-a-Xamarin-Android-Application-Deve

            database.CreateTableAsync<Alerte>().Wait();
        }

        public Task<List<Alerte>> GetItemsAsync()
        {
            return database.Table<Alerte>().ToListAsync();
        }

        public Task<List<Alerte>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<Alerte>("SELECT * FROM [Alerte] WHERE [Done] = 0");
        }

        public Task<Alerte> GetItemAsync(int id)
        {
            return database.Table<Alerte>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Alerte item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(Alerte item)
        {
            return database.DeleteAsync(item);
        }
    }
}

