using System.Data.SqlClient;

namespace AppPos.DataAccess
{
    public class ConnectionFactory : IConnectionFactory
    {
        private readonly string connectionString;
        public ConnectionFactory(string connection)
        {
            connectionString = connection;
        }
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
