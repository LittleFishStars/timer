using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计时器
{
    public partial class 计时 : Form
    {
        private long time = 0;
        public 计时(long time)
        {
            InitializeComponent();
            this.time = time;

            
        }

        private void 计时_Load(object sender, EventArgs e)
        {
            //System.Timers.Timer t = new System.Timers.Timer(time);
            //t.Elapsed += new System.Timers.ElapsedEventHandler(Ending);
            //t.AutoReset = false;
            //t.Enabled = true;

            Ending();
             //Close();
        }

        public void Ending()
        {
            DateTime Time = DateTime.Now;
            DateTime TimeNow = DateTime.Now;
            TimeSpan cha = TimeNow.Subtract(Time);
            //Console.WriteLine(cha.TotalSeconds);
            //string Time_str = Time.ToFileTime().ToString();
            //string TimeNow_str = TimeNow.Ticks.ToString();
            long time_s = (long)(time - cha.TotalSeconds);

            //while (time_s != 0)
            //{
            //TimeNow = DateTime.Now;
            //TimeNow_str = TimeNow.ToFileTime().ToString();
            //time_s = time + long.Parse(Time_str) - long.Parse(TimeNow_str);
            Tuple<string, string, string> t_fg = s__h_m_s(time_s);
                l_时.Text = t_fg.Item1;
                l_分.Text = t_fg.Item2;
                l_秒.Text = t_fg.Item3;
            //}
            //RedrawWindow();
        }

        public Tuple<string, string, string> s__h_m_s(long s)
        {
            if (s < 60)
            {
                Tuple<string, string, string> r = new Tuple<string, string, string>("00", "00", s.ToString());
                return bu_wei(r);
            }
            else if ((s >= 60) && (s < 3600))
            {
                double 临时 = s / 60;
                string min = ((int)Math.Floor(临时)).ToString();
                Tuple<string, string, string> r = new Tuple<string, string, string>("00", min, (s % 60).ToString());
                return bu_wei(r);
            }
            else
            {
                double 临时 = s / 3600;
                string h = ((int)Math.Floor(临时)).ToString();
                临时 = (s % 3600) / 60;
                string min = ((int)Math.Floor(临时)).ToString();
                Tuple<string, string, string> r = new Tuple<string, string, string>(h, min, ((s % 3600) % 60).ToString());
                return bu_wei(r);
            }
        }

        public Tuple<string, string, string> bu_wei(Tuple<string, string, string> sr)
        {
            Tuple<string, string, string> r = sr;
            if (sr.Item3.Length == 1)
            {
                r = new Tuple<string, string, string>(r.Item1, r.Item2, ("0" + r.Item3));
            }
            if (sr.Item2.Length == 1)
            {
                r = new Tuple<string, string, string>(r.Item1, ("0" + r.Item2), r.Item3);
            }
            if (sr.Item1.Length == 1)
            {
                r = new Tuple<string, string, string>(("0" + r.Item1), r.Item2, r.Item3);
            }
            return r;
        }

        private void l_时_Click(object sender, EventArgs e)
        {

        }
        DateTime Time = DateTime.Now;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            DateTime TimeNow = DateTime.Now;
            TimeSpan cha = TimeNow.Subtract(Time);
            //Console.WriteLine(cha.TotalSeconds);
            //string Time_str = Time.ToFileTime().ToString();
            //string TimeNow_str = TimeNow.Ticks.ToString();
            long time_s = (long)(time - cha.TotalSeconds);

            Tuple<string, string, string> t_fg = s__h_m_s(time_s);
            l_时.Text = t_fg.Item1;
            l_分.Text = t_fg.Item2;
            l_秒.Text = t_fg.Item3;

            
            if (time_s <= 5)
            {
                //SoundPlayer player = new SoundPlayer();
                //player.SoundLocation = "./音效 长.wav";
                //player.Load();
                //player.Play();

                ThreadStart sound = new ThreadStart(Sounds);
                //Console.WriteLine("In Main: Creating the Child thread");
                Thread soundThread = new Thread(sound);
                soundThread.Start();
            }
            

            if (time_s <= 0)
            {
                Close();
            }
        }

        public void Sounds()
        {
            SystemSounds.Asterisk.Play();
            //SystemSounds.Beep.Play();
            //SystemSounds.Exclamation.Play();
            //SystemSounds.Hand.Play();
            //SystemSounds.Question.Play();
        }
    }
}