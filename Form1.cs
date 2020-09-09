using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SelvrappoteringsApp
{
    public partial class Form1 : Form
    {
        private Login _loginForm;
        private Indstillinger _indstillinger;
        private SoundPlayer _player;

        public Form1()
        {
            InitializeComponent();
            _indstillinger = new Indstillinger(this);
            _loginForm = new Login(this, _indstillinger);
            LydlosB.Visible = false;

            //LydB.Visible = false;

            //_loginForm.Visible = false;
            //_indstillinger.Visible = false;
            _player = new SoundPlayer();

        }

        private void IndstillingerB_Click(object sender, EventArgs e)
        {
            _loginForm.Show();
            //this.Visible = false;
            //_loginForm.Visible = true;


            //_loginForm = new Login(this);
             //_loginForm.Show();
        }

        private void BatteriB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void EnableButtons(bool maaler, bool simpelReminder)
        {
            if (simpelReminder)
            {
                SimpelReminderTimer.Start();
            }
            else
            {
                SimpelReminderTimer.Stop();
                _SimpelCounter = 0;
                _threshold = 5;
            }

            if (maaler)
            {
                SpiseB.Enabled = true;
                SoveB.Enabled = true;
                ToiletB.Enabled = true;
                SlappeAfB.Enabled = true;
                AktivB.Enabled = true;
                MedicinB.Enabled = true;
                PositionsskiftB.Enabled = true;
                KoncentrationB.Enabled = true;
                AndetB.Enabled = true;

                SpiseB.BackColor = Color.PaleTurquoise;
                SoveB.BackColor = Color.PaleTurquoise;
                ToiletB.BackColor = Color.PaleTurquoise;
                SlappeAfB.BackColor = Color.PaleTurquoise;
                AktivB.BackColor = Color.PaleTurquoise;
                MedicinB.BackColor = Color.PaleTurquoise;
                PositionsskiftB.BackColor = Color.PaleTurquoise;
                KoncentrationB.BackColor = Color.PaleTurquoise;
                AndetB.BackColor = Color.PaleTurquoise;
            }
            else
            {
                SpiseB.Enabled = false;
                SoveB.Enabled = false;
                ToiletB.Enabled = false;
                SlappeAfB.Enabled = false;
                AktivB.Enabled = false;
                MedicinB.Enabled = false;
                PositionsskiftB.Enabled = false;
                KoncentrationB.Enabled = false;
                AndetB.Enabled = false;

                SpiseB.BackColor = Color.LightGray;
                SoveB.BackColor = Color.LightGray;
                ToiletB.BackColor = Color.LightGray;
                SlappeAfB.BackColor = Color.LightGray;
                AktivB.BackColor = Color.LightGray;
                MedicinB.BackColor = Color.LightGray;
                PositionsskiftB.BackColor = Color.LightGray;
                KoncentrationB.BackColor = Color.LightGray;
                AndetB.BackColor = Color.LightGray;
            }
        }

        private void LydB_Click(object sender, EventArgs e)
        {
            LydB.Visible = false;
            LydlosB.Visible = true;
            lyd = false;
            

        }

        private bool lyd = true;


        private void LydBeep()
        {
            if (lyd)
            {
                //Console.Beep(700, 400);
                //Console.Beep(500, 700);
            }
            else
            {
                
            }
        }

        private void LydlosB_Click(object sender, EventArgs e)
        {
            LydlosB.Visible = false;
            LydB.Visible = true;

            lyd = true;
        }

        private int _SimpelCounter = 0;
        private int _threshold = 5;

        private void SimpelReminderTimer_Tick(object sender, EventArgs e)
        {
            _SimpelCounter++;

            if (_SimpelCounter == _threshold)
            {
                _threshold += 5;

                LydBeep();

                //ReminderTB.Visible = true;
                //ReminderTB.Text = "Der er gået " + _SimpelCounter + "sekunder - Husk at rappoter!";
            }
            else if (_SimpelCounter <= _threshold-2)
            {
                //ReminderTB.Visible = false;
            }

        }
    }
}
