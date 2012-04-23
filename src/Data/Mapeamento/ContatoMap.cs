
using Dominio;
using FluentNHibernate.Mapping;

namespace Data.Mapeamento
{
    public sealed class ContatoMap : ClassMap<Contato>
    {
        public ContatoMap()
        {
            Id(x => x.Id);
            Map(x => x.Codigo);
            Map(x => x.Nome);
        }
    }
}
