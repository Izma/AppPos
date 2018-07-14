using System.Configuration;

namespace AppPos.Utils
{
    public static class Connection
    {
        public static string GetConnection => ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
    }
}