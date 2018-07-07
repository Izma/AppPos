using System.Data.SqlClient;

namespace AppPos.DataAccess
{
    public interface IConnectionFactory
    {
        SqlConnection GetConnection();
    }
}
