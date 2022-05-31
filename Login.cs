using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lbForgotPass_Click(object sender, EventArgs e)
        {
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {

        }

        private void lbCreateACC_Click(object sender, EventArgs e)
        {

        }

        private void tbUser_Click(object sender, EventArgs e)
        {
            tbUser.Clear();
            pnUser.BackColor = Color.FromArgb(78, 184, 206);
            tbUser.ForeColor = Color.FromArgb(78, 184, 206);

            pnPass.BackColor = Color.WhiteSmoke;
            tbPass.ForeColor = Color.WhiteSmoke;
        }

        private void tbPass_Click(object sender, EventArgs e)
        {
            tbPass.Clear();
            tbPass.PasswordChar = '•';
            pnPass.BackColor = Color.FromArgb(78, 184, 206);
            tbPass.ForeColor = Color.FromArgb(78, 184, 206);

            pnUser.BackColor = Color.WhiteSmoke;
            tbUser.ForeColor = Color.WhiteSmoke;

        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pbHome_Click(object sender, EventArgs e)
        {

        }
    }
}
