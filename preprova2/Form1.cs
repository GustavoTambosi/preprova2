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
    public partial class Form1 : Form
    {
        provaEntities bd = new provaEntities();
        public turma salva = new turma();
        public Form1()
        {
            InitializeComponent();
            btnSalvar.Click += salvar;
            btnSair.Click += sair;
        }

        private void sair(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

        private void salvar(object sender, EventArgs e)
        {
            turma novo = new turma()
            {
                nome = txtNome.Text,
            };
            bd.turma.Add(novo);
            bd.SaveChanges();
            MessageBox.Show("Salvo com sucesso!");
        }
    }
}
