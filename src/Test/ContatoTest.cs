
using Dominio;
using FluentNHibernate.Testing;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class ContatoTest : SessionFactoryTest
    {

        [Test]
        public void CrudTest()
        {
            new PersistenceSpecification<Contato>(Session)
                .CheckProperty(x => x.Codigo, 20)
                .CheckProperty(x => x.Nome, "Bianca")
                .VerifyTheMappings();

            
            //var contato = new Contato
            //                  {
            //                      Nome = "Bianca",
            //                  };

            //Session.Save(contato);
          
            //Session.Flush();
            //Session.Clear();
        }
    }
}
