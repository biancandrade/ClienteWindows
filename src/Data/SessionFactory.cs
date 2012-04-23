using System.Reflection;
using NHibernate.Tool.hbm2ddl;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using FluentNHibernate.Cfg;
using NHibernate.Cfg;

namespace Data
{
    public static class SessionFactory
    {
        public static ISessionFactory CreateFactory()
        {
            return Fluently.Configure()
                          .Database(MsSqlConfiguration.MsSql2008.ShowSql().ConnectionString(
                          c => c.FromConnectionStringWithKey("ConnString")).ShowSql)
                          .Mappings(
                            m => m.FluentMappings
                                  .AddFromAssembly(Assembly.GetExecutingAssembly()))
                //.ExposeConfiguration(BuildSchema)
                          .BuildSessionFactory();
        }

        private static void BuildSchema(Configuration cfg)
        {
            new SchemaExport(cfg)
                .Create(false, true);
        }
    }
}

