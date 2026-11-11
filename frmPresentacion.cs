using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnviosExpress
{
    public partial class frmPresentacion : Form
    {
        public frmPresentacion()
        {
            InitializeComponent();
            BordesRedondeados.Aplicar(this);
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.FormClosed += (s, args) => Application.Exit();
            login.Show(this);
            this.Hide();
        }
    }
}
