namespace GT.Administration.System.Infra.DataSources
{
    public class GtaSqlDB
    {
        private readonly DapperSqlDbConnection _con;

        public GtaSqlDB(ConfigurationSqlDbConnection<GtaSqlDB> con)
        {
            _con = con;
        }

    }
}
