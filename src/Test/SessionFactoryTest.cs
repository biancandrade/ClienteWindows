
using Data;
using NHibernate;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class SessionFactoryTest
    {
        private const string ConnString = @"Database=db_contato;Server=BIANCA-PC\b1;user=sa;pwd=sap@123;";
        protected ISession Session { get; private set; }

        [SetUp]
        public void CanCreateSchemaTest()
        {
            ISessionFactory factory = SessionFactory.CreateFactory();
            Session = factory.OpenSession();

        }

        [TearDown]
        public virtual void TearDown()
        {
            // Session.Close();
            Session.Dispose();
        }
    }
}
