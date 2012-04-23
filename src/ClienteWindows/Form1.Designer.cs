using System.Drawing;
using System.Windows.Forms;

namespace ClienteWindows
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contatoBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.contatoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.contatoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contatoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpContato = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgdContatos = new System.Windows.Forms.DataGridView();
            this.columnCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contatoBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.db_contatoDataSet = new ClienteWindows.db_contatoDataSet();
            this.contatoTableAdapter = new ClienteWindows.db_contatoDataSetTableAdapters.ContatoTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource)).BeginInit();
            this.grpContato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdContatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_contatoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // contatoBindingSource3
            // 
            this.contatoBindingSource3.DataMember = "Contato";
            // 
            // contatoBindingSource1
            // 
            this.contatoBindingSource1.DataMember = "Contato";
            // 
            // contatoBindingSource
            // 
            this.contatoBindingSource.DataMember = "Contato";
            // 
            // grpContato
            // 
            this.grpContato.Controls.Add(this.btnSalvar);
            this.grpContato.Controls.Add(this.btnAtualizar);
            this.grpContato.Controls.Add(this.btnCancelar);
            this.grpContato.Controls.Add(this.btnEditar);
            this.grpContato.Controls.Add(this.label2);
            this.grpContato.Controls.Add(this.label1);
            this.grpContato.Controls.Add(this.txtCodigo);
            this.grpContato.Controls.Add(this.txtNome);
            this.grpContato.Controls.Add(this.btnExcluir);
            this.grpContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.grpContato.Location = new System.Drawing.Point(19, 19);
            this.grpContato.Name = "grpContato";
            this.grpContato.Size = new System.Drawing.Size(562, 187);
            this.grpContato.TabIndex = 7;
            this.grpContato.TabStop = false;
            this.grpContato.Text = "Cadastro de Contato";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(38, 145);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 22);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(38, 144);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 15;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(281, 145);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 22);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(119, 145);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 22);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(73, 52);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(93, 21);
            this.txtCodigo.TabIndex = 9;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(73, 86);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(374, 21);
            this.txtNome.TabIndex = 8;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(200, 145);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 22);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dgdContatos
            // 
            this.dgdContatos.AutoGenerateColumns = false;
            this.dgdContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdContatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnCode,
            this.columnName});
            this.dgdContatos.DataSource = this.contatoBindingSource4;
            this.dgdContatos.Location = new System.Drawing.Point(18, 224);
            this.dgdContatos.Name = "dgdContatos";
            this.dgdContatos.Size = new System.Drawing.Size(563, 207);
            this.dgdContatos.TabIndex = 12;
            this.dgdContatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdContatos_SelectionChanged);
            // 
            // columnCode
            // 
            this.columnCode.DataPropertyName = "Codigo";
            this.columnCode.HeaderText = "Codigo";
            this.columnCode.Name = "columnCode";
            // 
            // columnName
            // 
            this.columnName.DataPropertyName = "Nome";
            this.columnName.HeaderText = "Nome";
            this.columnName.Name = "columnName";
            // 
            // contatoBindingSource4
            // 
            this.contatoBindingSource4.DataMember = "Contato";
            this.contatoBindingSource4.DataSource = this.db_contatoDataSet;
            // 
            // db_contatoDataSet
            // 
            this.db_contatoDataSet.DataSetName = "db_contatoDataSet";
            this.db_contatoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contatoTableAdapter
            // 
            this.contatoTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(26, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 13;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(506, 456);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 491);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgdContatos);
            this.Controls.Add(this.grpContato);
            this.Name = "Form1";
            this.Text = "Contato";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource)).EndInit();
            this.grpContato.ResumeLayout(false);
            this.grpContato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdContatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_contatoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpContato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.BindingSource contatoBindingSource;
        
        private System.Windows.Forms.BindingSource contatoBindingSource1;

        private System.Windows.Forms.BindingSource contatoBindingSource2;
       
        private System.Windows.Forms.BindingSource contatoBindingSource3;
        
        private System.Windows.Forms.DataGridView dgdContatos;
        private db_contatoDataSet db_contatoDataSet;
        private System.Windows.Forms.BindingSource contatoBindingSource4;
        private db_contatoDataSetTableAdapters.ContatoTableAdapter contatoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private Button btnEditar;
        private Button btnCancelar;
        private Button btnAtualizar;
        private Label label3;
        private Button btnSair;

    }
}

