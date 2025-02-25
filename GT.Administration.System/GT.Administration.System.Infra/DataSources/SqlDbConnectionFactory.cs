using System.Data;
using Microsoft.Data.SqlClient;



namespace GT.Administration.System.Infra.DataSources
{
    public class SqlDbConnectionFactory
    {
        protected readonly string _connectionString;

        public SqlDbConnectionFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<IDbConnection> GetOpenConnectionAsync()
        {
            var con = new SqlConnection(_connectionString);
            await con.OpenAsync().ConfigureAwait(false);
            return con;
        }
    }
}
