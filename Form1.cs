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

        private SoundPlayer sound;
        private void LydBeep()
        {
            if (lyd)
            {
                SoundPlayer sound = new SoundPlayer("/home/pi/APP/A-Tone-His_Self-1266414414.wav");
                sound.PlaySync();
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
        private int _threshold = 10;

        private void SimpelReminderTimer_Tick(object sender, EventArgs e)
        {
            _simpelCounter++;

            if (_simpelCounter == _threshold)
            {
                _threshold += 100;

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
                if (_simpelCounter == o)
                {
                    AndetB.Enabled = true;
                    AndetB.BackColor = Color.PaleTurquoise;
                    _andetState = false;
                }
            }
            if (_spiseState)
            {
                if (_simpelCounter == o)
                {
                    SpiseB.Enabled = true;
                    SpiseB.BackColor = Color.PaleTurquoise;
                    _spiseState = false;
                }
            }
            if (_soveState)
            {
                if (_simpelCounter == o)
                {
                    SoveB.Enabled = true;
                    SoveB.BackColor = Color.PaleTurquoise;
                    _soveState = false;
                }
            }
            if (_toiletState)
            {
                if (_simpelCounter == o)
                {
                    ToiletB.Enabled = true;
                    ToiletB.BackColor = Color.PaleTurquoise;
                    _toiletState = false;
                }
            }
            if (_SlappeAfState)
            {
                if (_simpelCounter == o)
                {
                    SlappeAfB.Enabled = true;
                    SlappeAfB.BackColor = Color.PaleTurquoise;
                    _SlappeAfState = false;
                }
            }
            if (_AktivState)
            {
                if (_simpelCounter == o)
                {
                    AktivB.Enabled = true;
                    AktivB.BackColor = Color.PaleTurquoise;
                    _AktivState = false;
                }
            }
            if (_medicinState)
            {
                if (_simpelCounter == o)
                {
                    MedicinB.Enabled = true;
                    MedicinB.BackColor = Color.PaleTurquoise;
                    _medicinState = false;
                }
            }
            if (_PositionState)
            {
                if (_simpelCounter == o)
                {
                    PositionsskiftB.Enabled = true;
                    PositionsskiftB.BackColor = Color.PaleTurquoise;
                    _PositionState = false;
                }
            }
            if (_KoncentrationsState)
            {
                if (_simpelCounter == o)
                {
                    KoncentrationB.Enabled = true;
                    KoncentrationB.BackColor = Color.PaleTurquoise;
                    _KoncentrationsState = false;
                }
            }
        }
        
        private List<string> _AktivitetsList = new List<string>(); //Hvad bruges denne til?
        private int o = 0;

        private bool _spiseState = false;
        private void SpiseB_Click(object sender, EventArgs e)
        {
            SpiseB.BackColor = Color.LightGray;
            SpiseB.Enabled = false;

            MessageBox.Show("Din aktivitet er gemt.");

            //Kode for at gemme i en fil:
            File.AppendAllText("/home/pi/APP/Aktivitetslog.txt", "Spiser\t\t" + ";\tDate;" + DateTime.Now + "\n");

            o = _simpelCounter + 10;
            _spiseState = true;
        }
        
        private bool _andetState = false;
        private void AndetB_Click(object sender, EventArgs e)
        {
            AndetB.BackColor = Color.LightGray;
            AndetB.Enabled = false;

            MessageBox.Show("Din aktivitet er gemt.");

            //Kode for at gemme i en fil:
            File.AppendAllText("/home/pi/APP/Aktivitetslog.txt", "Andet\t\t" + ";\tDate;" + DateTime.Now + "\n");

            o = _simpelCounter + 10;
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

        private bool _soveState = false;
        private void SoveB_Click(object sender, EventArgs e)
        {
            SoveB.BackColor = Color.LightGray;
            SoveB.Enabled = false;

            MessageBox.Show("Din aktivitet er gemt.");

            //Kode for at gemme i en fil:
            File.AppendAllText("/home/pi/APP/Aktivitetslog.txt", "Sover\t\t" + ";\tDate;" + DateTime.Now + "\n");
            o = _simpelCounter + 10;

            _soveState = true;
        }

        private bool _toiletState = false;
        private void ToiletB_Click(object sender, EventArgs e)
        {
            ToiletB.BackColor = Color.LightGray;
            ToiletB.Enabled = false;

            MessageBox.Show("Din aktivitet er gemt.");

            //Kode for at gemme i en fil:
            File.AppendAllText("/home/pi/APP/Aktivitetslog.txt", "Toilet\t\t" + ";\tDate;" + DateTime.Now + "\n");
            o = _simpelCounter + 10;

            _toiletState = true;
        }

        private bool _SlappeAfState = false;
        private void SlappeAfB_Click(object sender, EventArgs e)
        {
            SlappeAfB.BackColor = Color.LightGray;
            SlappeAfB.Enabled = false;

            MessageBox.Show("Din aktivitet er gemt.");

            //Kode for at gemme i en fil:
            File.AppendAllText("/home/pi/APP/Aktivitetslog.txt", "Slapper af\t" + ";\tDate;" + DateTime.Now + "\n");
            o = _simpelCounter + 10;

            _SlappeAfState = true;
        }

        private bool _AktivState = false;
        private void AktivB_Click(object sender, EventArgs e)
        {
            AktivB.BackColor = Color.LightGray;
            AktivB.Enabled = false;

            MessageBox.Show("Din aktivitet er gemt.");

            //Kode for at gemme i en fil:
            File.AppendAllText("/home/pi/APP/Aktivitetslog.txt", "Aktiv\t\t" + ";\tDate;" + DateTime.Now + "\n");
            o = _simpelCounter + 10;

            _AktivState = true;
        }

        private bool _medicinState = false;
        private void MedicinB_Click(object sender, EventArgs e)
        {
            MedicinB.BackColor = Color.LightGray;
            MedicinB.Enabled = false;

            MessageBox.Show("Din aktivitet er gemt.");

            //Kode for at gemme i en fil:
            File.AppendAllText("/home/pi/APP/Aktivitetslog.txt", "Medicin\t\t" + ";\tDate;" + DateTime.Now + "\n");
            o = _simpelCounter + 10;

            _medicinState = true;
        }

        private bool _PositionState = false;
        private void PositionsskiftB_Click(object sender, EventArgs e)
        {
            PositionsskiftB.BackColor = Color.LightGray;
            PositionsskiftB.Enabled = false;

            MessageBox.Show("Din aktivitet er gemt.");

            //Kode for at gemme i en fil:
            File.AppendAllText("/home/pi/APP/Aktivitetslog.txt", "Positions skift\t" + ";\tDate;" + DateTime.Now + "\n");
            o = _simpelCounter + 10;

            _PositionState = true;
        }

        private bool _KoncentrationsState = false;
        private void KoncentrationB_Click(object sender, EventArgs e)
        {
            KoncentrationB.BackColor = Color.LightGray;
            KoncentrationB.Enabled = false;

            MessageBox.Show("Din aktivitet er gemt.");

            //Kode for at gemme i en fil:
            File.AppendAllText("/home/pi/APP/Aktivitetslog.txt", "koncentrere sig\t" + ";\tDate;" + DateTime.Now + "\n");
            o = _simpelCounter + 10;

            _KoncentrationsState = true;
        }


    }
}
