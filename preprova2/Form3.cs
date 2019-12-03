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
        public turma salva = new turma();
        public Form3()
        {
            InitializeComponent();            
        }
    }
}
