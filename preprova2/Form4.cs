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
    public partial class Form3 : Form
    {
        provaEntities bd = new provaEntities();
        public aluno logado = new aluno();
        public Form3()
        {
            InitializeComponent();
            btnCadastrar.Click += Cadastrar;
            btnTurma.Click += turma;
            btnLogar.Click += logar;
            btnFechar.Click += fechar;
        }

        private void fechar(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logar(object sender, EventArgs e)
        {
            logado = bd.aluno.Where(a => a.login.Equals(txtLogin.Text)
            && a.senha.Equals(txtSenha.Text) && a.ativo.Equals(true)).FirstOrDefault();
            if (logado != null)
            {
                MessageBox.Show($"usuario {logado.nome} logado com sucesso!");
            }
            else
            {
                MessageBox.Show("Login inválido");
            }
        }

        private void turma(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void Cadastrar(object sender, EventArgs e)
        {
            new From2().Show();
            this.Hide();
        }
    }
}
