
namespace GT.Administration.System.Common.Infra
{
    public abstract class BaseDao
    {
        protected BaseDao(ISqlDatabaseConnection connection)
        {
            Connection = connection;
        }

        protected ISqlDatabaseConnection Connection { get; }
    }
}
