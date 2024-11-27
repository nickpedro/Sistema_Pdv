using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Pdv
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void MenuSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuFuncionario_Click(object sender, EventArgs e)
        {
            cadastro.frmFuncionario frm = new cadastro.frmFuncionario();
            frm.ShowDialog(); 
        }

        private void MenuCargo_Click(object sender, EventArgs e)
        {
            cadastro.frmCargo frm = new cadastro.frmCargo();
            frm.ShowDialog();
        }
    }
}
