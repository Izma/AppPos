using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace AppPos.DataAccess
{
    public abstract class BaseRepository
    {
        private readonly IConnectionFactory factory;
        public BaseRepository(IConnectionFactory _connection)
        {
            factory = _connection;
        }

        protected async Task<T> WithConnection<T>(Func<IDbConnection, Task<T>> getData)
        {
            try
            {
                using (var connection = factory.GetConnection())
                {
                    await connection.OpenAsync(); // Asynchronously open a connection to the database
                    return await getData(connection); // Asynchronously execute getData, which has been passed in as a Func<IDBConnection, Task<T>>
                }
            }
            catch (TimeoutException ex)
            {
                throw new Exception(String.Format("{0}.WithConnection() experienced a SQL timeout", GetType().FullName), ex);
            }
            catch (SqlException ex)
            {
                throw new Exception(String.Format("{0}.WithConnection() experienced a SQL exception (not a timeout)", GetType().FullName), ex);
            }
        }
    }
}
