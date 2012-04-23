
using NHibernate;

namespace Data.Repositorios
{
    public class ConexaoRepositorios
    {
        public static ISession GetSession()
        {
            ISessionFactory factory = SessionFactory.CreateFactory();
            return factory.OpenSession(); 
        }
    }
}
