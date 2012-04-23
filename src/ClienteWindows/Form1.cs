using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Data.Repositorios;
using Dominio;
using Dominio.Repositorios;
using NHibernate;


namespace ClienteWindows
{
    public partial class Form1 : Form
    {
        private IContatoRepositorio _repositorio;
        private Contato contato;

        public Form1()
        {
            InitializeComponent();
            btnEditar.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            var id = string.IsNullOrEmpty(txtCodigo.Text) ? 0 : Convert.ToInt32(txtCodigo.Text);
            contato = _repositorio.ObterPor(id) ?? new Contato();

            contato.Codigo = Convert.ToInt32(txtCodigo.Text);
            contato.Nome = txtNome.Text;

            _repositorio.AtualizarProcedure(contato);

            CarregaGrid();
            LimpaControles();
            btnSalvar.Enabled = true;
            btnSalvar.BringToFront();
            btnEditar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnSalvar.BringToFront();
            btnSalvar.Enabled = true;
            txtCodigo.Enabled = true;
            txtNome.Enabled = true;
            LimpaControles();
        }
        
        public void Salvar()
        {
            _repositorio = new ContatoRepositorio();
            
            if (txtCodigo.Text == "" || txtNome.Text == "")
            {
                MessageBox.Show("Campo(s) nulo(s)! Informe um contato!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if(ValidarCodigo())
                {
                    var id = string.IsNullOrEmpty(txtCodigo.Text) ? 0 : Convert.ToInt32(txtCodigo.Text);
                    contato = _repositorio.ObterPor(id) ?? new Contato();

                    contato.Codigo = Convert.ToInt32(txtCodigo.Text);
                    contato.Nome = txtNome.Text;

                    _repositorio.Salvar(contato);
                    
                    CarregaGrid();
                    LimpaControles();
                }
                else
                {
                    MessageBox.Show("Código já existente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
 
        private bool ValidarCodigo()
        {
            if (txtCodigo.Text != null)
            {
                var codigo = string.IsNullOrEmpty(txtCodigo.Text) ? 0 : Convert.ToInt32(txtCodigo.Text);
                contato = _repositorio.ObterPor(codigo);

                if (contato == null)
                    return true;
            }
            return false;
        }

        public void Excluir()
        {
             _repositorio = new ContatoRepositorio();

            var msg = string.Format("Deseja excluir o contato: {0} ?", dgdContatos.CurrentRow.Cells["columnName"].Value);

            if (MessageBox.Show(msg, Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2).Equals(DialogResult.Yes))
            {
                contato = _repositorio.ObterPor((int)dgdContatos.CurrentRow.Cells["columnCode"].Value);
                _repositorio.Excluir(contato);

                CarregaGrid();
                LimpaControles();
            }
        }

        private void Editar()
        {
            btnAtualizar.BringToFront();
            btnAtualizar.Enabled = true;
            txtCodigo.Enabled = true;
            txtNome.Enabled = true;
        }

        
        private void CarregaGrid()
        {
            _repositorio = new ContatoRepositorio();
            dgdContatos.DataSource = _repositorio.ObterTodos().ToList();
            TotalRegistros();
        }

        private void LimpaControles()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
        }

        public void SelecionaContato()
        {
            if (dgdContatos.CurrentRow == null)
                return;

            txtCodigo.Text = Convert.ToString(dgdContatos.CurrentRow.Cells["columnCode"].Value);
            txtNome.Text = Convert.ToString(dgdContatos.CurrentRow.Cells["columnName"].Value);
            btnEditar.Enabled = true;
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
        }

        private void dgdContatos_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        {
            SelecionaContato();
            btnSalvar.Enabled = false;
        }

        private void TotalRegistros()
        {
            var linhas = dgdContatos.RowCount;
            label3.Text = "Total de registros: " + linhas;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
