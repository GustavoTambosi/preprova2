using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace preprova2
{
    public partial class From2 : Form
    {
        provaEntities bd = new provaEntities();
        public aluno salvo = new aluno();
        public From2()
        {
            InitializeComponent();
            btnSalvar.Click += salvar;
            btnSair.Click += sair;
            btnVoltar.Click += voltar;
            carregarTurma();
        }

        private void carregarTurma()
        {
            cmbTurma.DataSource = bd.turma.Select(a => a.nome).ToList();
        }

        private void voltar(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

        private void sair(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

        private void salvar(object sender, EventArgs e)
        {
            aluno novo = new aluno()
            {
                nome = txtNome.Text,
                email = txtEmail.Text,
                login = txtLogin.Text,
                senha = txtSenha.Text,
            };
            bd.aluno.Add(novo);
            bd.SaveChanges();
            MessageBox.Show("Salvo com sucesso!");
        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
