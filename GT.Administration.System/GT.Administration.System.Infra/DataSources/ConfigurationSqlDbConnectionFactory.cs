using Microsoft.Extensions.Configuration;

namespace GT.Administration.System.Infra.DataSources
{
    public class ConfigurationSqlDbConnectionFactory<T> : SqlDbConnectionFactory
    {
        public ConfigurationSqlDbConnectionFactory(IConfigurationRoot config)
            : base(config.GetConnectionString(typeof(T).Name) ?? throw new InvalidOperationException($"Cadena de conexion {typeof(T).Name} no encontrada."))
        { }
    }
}
