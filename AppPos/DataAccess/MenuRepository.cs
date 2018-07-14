using AppPos.Models;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace AppPos.DataAccess
{
    public class MenuRepository : BaseRepository, IMenuRepository
    {
        public MenuRepository(IConnectionFactory _connection) : base(_connection)
        {
        }

        public async Task<int> AddMenu(MenuModel model)
        {
            return await WithConnection(async q =>
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Name", model.Name, DbType.String, ParameterDirection.Input, 100);
                parameters.Add("@parentId", model.ParentId, DbType.Int32, ParameterDirection.Input);
                parameters.Add("@order", model.Order, DbType.Int32, ParameterDirection.Input);
                parameters.Add("@Status", model.Status, DbType.Int32, ParameterDirection.Input);
                parameters.Add("@url", model.Url, DbType.String, ParameterDirection.Input, 100);
                parameters.Add("@userId", model.UserId, DbType.Int32, ParameterDirection.Input);
                var result = await q.QueryAsync<int>(
                    sql: "[dbo].[spAddMenu]",
                    param: parameters,
                    commandType: CommandType.StoredProcedure);
                return result.FirstOrDefault();
            });
        }

        public async Task<IQueryable<MenuModel>> GetMenuList(int userId)
        {
            return await WithConnection(async q =>
            {
                var parameters = new DynamicParameters();
                parameters.Add("@userId", userId, DbType.Int32, ParameterDirection.Input);
                var result = await q.QueryAsync<MenuModel>(
                    sql: "[dbo].[spGetMenuList]",
                    param: parameters,
                    commandType: CommandType.StoredProcedure
                    );
                return result.AsQueryable();
            });
        }
    }
}