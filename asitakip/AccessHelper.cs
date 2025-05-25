using System.Data.OleDb;

namespace asitakip
{
    public static class AccessHelper
    {
        public static string connectionString =
            @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=asi.accdb;";

        public static OleDbConnection GetConnection()
        {
            return new OleDbConnection(connectionString);
        }
    }
}
