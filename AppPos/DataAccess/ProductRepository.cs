using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppPos.Models;
using Dapper;
using System.Data;

namespace AppPos.DataAccess
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(IConnectionFactory _connection) : base(_connection)
        {
        }

        public async Task<List<ProductModel>> GetProduct()
        {
            return await WithConnection(async q =>
            {
                var result = await q.QueryAsync<ProductModel>(
                    sql: "[dbo].[spGetProducts]",
                    param:null,
                    commandType:CommandType.Text
                    );
                return result.ToList();
            });
            
        }
    }
}
