using CalendarioAtividadesAlusivas.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Task<int> InsertDias(List<Dias> a)
        {
            return _conn.InsertAllAsync(a);
        }
        public async Task<bool> TabelaTemDadosAsync()
        {
            var count = await _conn.Table<Dias>().CountAsync();
            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    
}
