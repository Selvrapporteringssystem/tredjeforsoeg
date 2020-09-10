using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Media;
using System.IO;

namespace SelvrappoteringsApp
{
    public partial class Form1 : Form
    {
        private Login _loginForm;
        private Indstillinger _indstillinger;

        public Form1()
        {
            InitializeComponent();
            _indstillinger = new Indstillinger(this);
            _loginForm = new Login(this, _indstillinger);
            LydlosB.Visible = false;

            //LydB.Visible = false;

            //_loginForm.Visible = false;
            //_indstillinger.Visible = false;

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
                _simpelCounter = 0;
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

        SoundPlayer sound = new SoundPlayer("/home/pi/APP/A-Tone-His_Self-1266414414.wav");
        private void LydBeep()
        {
            if (lyd)
            {
                sound.Play();
                sound.Play();
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

        private int _simpelCounter = 0;
        private int _threshold = 5;

        private void SimpelReminderTimer_Tick(object sender, EventArgs e)
        {
            _simpelCounter++;

            if (_simpelCounter == _threshold)
            {
                _threshold += 5;

                LydBeep();

                //ReminderTB.Visible = true;
                //ReminderTB.Text = "Der er gået " + _SimpelCounter + "sekunder - Husk at rappoter!";
            }
            else if (_simpelCounter <= _threshold-2)
            {
                //ReminderTB.Visible = false;
            }

            if (_andetState)
            {
                AndetB.BackColor = Color.LightGray;
                AndetB.Enabled = false;

                if (_simpelCounter == o)
                {
                    AndetB.Enabled = true;
                    AndetB.BackColor = Color.PaleTurquoise;
                    _andetState = false;
                }
            }
        }

        private void SpiseB_Click(object sender, EventArgs e)
        {

        }

        private List<string> _AktivitetsList = new List<string>();

        private int o = 0;
        private bool _andetState = false;

        private void AndetB_Click(object sender, EventArgs e)
        {
            //Kode for at gemme i en fil:
            File.AppendAllText("/home/pi/APP/Aktivitetslog.txt", "Andet " + "; Date;" + DateTime.Now + "\n");

            o = _simpelCounter + 3;
            _andetState = true;


            // Hvis vi vil hente data:

                //    string inputRecord;
                //    string[] inputFields;

                //    FileStream input = new FileStream("..\\Aktivitetslog.txt", FileMode.Open, FileAccess.Read);
                //    StreamReader fileReader = new StreamReader(input);

                //    while ((inputRecord = fileReader.ReadLine()) != null)
                //    {
                //        inputFields = inputRecord.Split(';');

                //        _AktivitetsList.Add(inputFields[1]);
                //    }
                //    fileReader.Close();
                //}

        }
        }
}
