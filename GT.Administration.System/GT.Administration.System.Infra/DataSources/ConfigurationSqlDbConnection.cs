namespace GT.Administration.System.Infra.DataSources
{
    public class ConfigurationSqlDbConnection<T> : DapperSqlDbConnection
    {
        public ConfigurationSqlDbConnection(ConfigurationSqlDbConnectionFactory<T> factory)
            : base(factory)
        { }
    }
}
