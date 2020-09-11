using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelvrappoteringsApp
{
    public partial class Indstillinger : Form
    {
        private Form1 _form1;

        public Indstillinger(Form1 form1)
        {
            InitializeComponent();
            radioButton1.Checked = true;
            radioButton3.Checked = true;

            _form1 = form1;
        }

        private bool _Maaler = false;
        private bool _SimpelReminder = false;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            
        }

        private void NyMaalingB_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                _SimpelReminder = true;
            }
            else if (radioButton4.Checked == true)
            {
                _SimpelReminder = false;
            }

            _Maaler = true;
            AfslutMaalingB.Enabled = true;
            NyMaalingB.Enabled = false;
            _form1.EnableButtons(_Maaler, _SimpelReminder);

            File.AppendAllText("/home/pi/APP/Aktivitetslog.txt", "\nNY MÅLING " + "; Date;" + DateTime.Now + "\n");
        }

        private void AfslutMaalingB_Click(object sender, EventArgs e)
        {
            _Maaler = false;
            _SimpelReminder = false;
            NyMaalingB.Enabled = true;
            AfslutMaalingB.Enabled = false;
            _form1.EnableButtons(_Maaler, _SimpelReminder);

            File.AppendAllText("/home/pi/APP/Aktivitetslog.txt", "\nAFSLUTTER MÅLING " + "; Date;" + DateTime.Now + "\n");
        }
    }
}
