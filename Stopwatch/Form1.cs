namespace Stopwatch
{
    public partial class stopwatch : Form
    {
        public stopwatch()
        {
            InitializeComponent();
        }
        int second, minute, hour;
        bool Dark = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (second == 60)
            {
                second = 0;
                LblSec.Text = second.ToString();

                minute++;
                LblMin.Text = minute.ToString();
            }

            if (minute == 60)
            {
                minute = 0;
                LblMin.Text = minute.ToString();
                hour++;
                LblHour.Text = hour.ToString();
            }
            second++;
            LblSec.Text = second.ToString();

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            Pause();
        }

        private void BtnRes_Click(object sender, EventArgs e)
        {
            Restart();
        }
        private void PicDarkMode_Click(object sender, EventArgs e)
        {
            DarkMode();
        }



        // CLASSES
        private void Restart()
        {
            timer1.Stop();
            second = 0;
            minute = 0;
            hour = 0;
            LblSec.Text = "00";
            LblMin.Text = "00";
            LblHour.Text = "00";
            BtnPause.Enabled = false;
            BtnStart.Enabled = true;
        }

        private void Pause()
        {
            timer1.Stop();
            LblPause.Visible = true;
            BtnStart.Enabled = true;
            BtnPause.Enabled = false;
            BtnRes.Enabled = true;
        }
        private void Start()
        {
            timer1.Start();
            LblPause.Visible = false;
            BtnStart.Enabled = false;
            BtnPause.Enabled = true;
            BtnRes.Enabled = true;

        }
        private void DarkMode()
        {
            if (Dark == false)
            {

                this.BackColor = Color.Black;
                LblSec.ForeColor = Color.White;
                LblMin.ForeColor = Color.White;
                LblHour.ForeColor = Color.White;
                LblPause.ForeColor = Color.White;
                BtnStart.ForeColor = Color.White;
                BtnPause.ForeColor = Color.White;
                BtnRes.ForeColor = Color.White;
                PicDarkMode.Image = Properties.Resources.light_mode;
                PicDarkMode.Refresh();
                PicDarkMode.Visible = true;
                Dark = true;

            }
            else
            {
                this.BackColor = Color.White;
                LblSec.ForeColor = Color.Black;
                LblMin.ForeColor = Color.Black;
                LblHour.ForeColor = Color.Black;
                LblPause.ForeColor = Color.Black;
                BtnStart.ForeColor = Color.Black;
                BtnPause.ForeColor = Color.Black;
                BtnRes.ForeColor= Color.Black;
                PicDarkMode.Image = Properties.Resources.dark_mode;
                PicDarkMode.Refresh();
                PicDarkMode.Visible = true;
                Dark = false;
            }
        }


    }
}