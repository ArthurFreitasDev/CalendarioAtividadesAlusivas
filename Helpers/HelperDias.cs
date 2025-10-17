using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using CalendarioAtividadesAlusivas.Models;

namespace CalendarioAtividadesAlusivas.Helpers
{
    public class HelperDias
    {
        readonly SQLiteAsyncConnection _conn;

        public HelperDias(string path)
        {
            _conn = new SQLiteAsyncConnection(path);
            _conn.CreateTableAsync<Dias>().Wait();
        }

        public Task<List<Dias>> GetAllDiasAsync()
        {
            return _conn.Table<Dias>().ToListAsync();
        }

        public Task<int> InsertDias(Dias a)
        {
            return _conn.InsertAsync(a);
        }
    }
    
}
