using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelvrappoteringsApp
{
    public partial class Login : Form
    {
        private Indstillinger _indstillingerForm;
        private Form1 _form1;

        public Login(Form1 form1, Indstillinger indstillinger)
        {
            InitializeComponent();
            _form1 = form1;
            _indstillingerForm = indstillinger;
        }

        private void AnnullerB_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private string _Brugernavn = "Admin";
        private string _Password = "VCRVCR";

        private void LoginB_Click(object sender, EventArgs e)
        {
            if (BrugernavnTB.Text == _Brugernavn && PasswordTB.Text == _Password)
            {
                
                _indstillingerForm.Show();
                this.Visible = false;
            }
            else
            {
                label3.Visible = true;
            }

        }
    }
}
