using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dominio.Repositorios;
using NHibernate;
using NHibernate.Criterion;
using Dominio;

namespace Data.Repositorios
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        public void Salvar(Contato contato)
        {
            ConexaoRepositorios.GetSession().SaveOrUpdate(contato);
        }

        public void Excluir(Contato contato)
        {
            var tran = ConexaoRepositorios.GetSession().BeginTransaction();
                ConexaoRepositorios.GetSession().Delete(contato);
                tran.Commit();
        }

        public void AtualizarProcedure(Contato contato)
        {
                       var connection = new SqlConnection
                         {
                             ConnectionString = ConfigurationManager
                            .ConnectionStrings["ConnString"]
                            .ConnectionString
                         };

            var cmdUpdate = new SqlCommand("SP_UPDATE_CONTATO", connection)
                                {
                                    CommandType = CommandType.StoredProcedure
                                };

            cmdUpdate.Parameters.AddWithValue("@Codigo", contato.Codigo);
            cmdUpdate.Parameters.AddWithValue("@Nome", contato.Nome);

            connection.Open();

            try
            {
                cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception();
            }
            finally
            {
                connection.Close();
            }
        }

        public void Atualizar(Contato contato)
        {
            var tran = ConexaoRepositorios.GetSession().BeginTransaction();
            ConexaoRepositorios.GetSession().Update(contato);
            tran.Commit();
        }

        public Contato ObterPor(int codigo)
        {
            ICriteria search = ConexaoRepositorios.GetSession().CreateCriteria(typeof (Contato));
            search.Add(Restrictions.Eq("Codigo", codigo));
            return search.List<Contato>().SingleOrDefault();
        }

        public IEnumerable<Contato> ObterTodos()
        {
            return ConexaoRepositorios.GetSession().CreateCriteria(typeof(Contato)).List<Contato>();
        }
    } 
}