using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计时器
{
    public partial class 计时器 : Form
    {
        public 计时器()
        {
            InitializeComponent();
        }

        private void 计时器_Load(object sender, EventArgs e)
        {

        }

        public int time_天 = 0;
        public int time_时 = 0;
        public int time_分 = 0;
        public int time_秒 = 0;
        public int time = 0;

        public void f_刷新()
        {
            时.Text = time_时.ToString();
            分.Text = time_分.ToString();
            秒.Text = time_秒.ToString();
        }

        public void f_时()
        {
            if (time_时 < 23)
            {
                time_时 ++;
            }
            else
            {
                time_时 = 0;
            }
            f_刷新();
        }

        public void f_分()
        {
            if (time_分 < 59)
            {
                time_分 ++;
            }
            else
            {
                time_分 = 0;
                f_时();
            }
            f_刷新();
        }

        public void f_秒()
        {
            if (time_秒 < 59)
            {
                time_秒 ++;
            }
            else
            {
                time_秒 = 0;
                f_分();
            }
            f_刷新();
        }

        private void 秒_加_Click(object sender, EventArgs e)
        {
            f_秒();
        }

        private void 分_加_Click(object sender, EventArgs e)
        {
            f_分();
        }

        private void 时_加_Click(object sender, EventArgs e)
        {
            f_时();
        }

        private void 时_减_Click(object sender, EventArgs e)
        {
            if (time_时 > 0)
            {
                time_时--;
            }else if (time_时 == 0)
            {
                time_时 = 23;
            }
            f_刷新();
        }

        private void 分_减_Click(object sender, EventArgs e)
        {
            if (time_分 > 0)
            {
                time_分--;
            }else if (time_分 == 0)
            {
                time_分 = 59;
            }
            f_刷新();
        }

        private void 秒_减_Click(object sender, EventArgs e)
        {
            if (time_秒 > 0)
            {
                time_秒--;
            }
            else if (time_秒 == 0)
            {
                time_秒 = 59;
            }
            f_刷新();
        }

        public void f_go()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(true);
            //Application.Run(new 计时(time));
            //Form.ShowDialog(new 计时(time));
            new 计时(time).ShowDialog();
        }

        private void go_Click(object sender, EventArgs e)
        {
            time = (time_秒 + (time_分 * 60) + (time_时 * 3600));
            f_go();
        }

        private void 快捷时间_30s_Click(object sender, EventArgs e)
        {
            time = 30;
            f_go();
        }

        private void 快捷时间_1min_Click(object sender, EventArgs e)
        {
            time = 60;
            f_go();
        }

        private void 快捷时间_2min_Click(object sender, EventArgs e)
        {
            time = 120;
            f_go();
        }

        private void 快捷时间_3min_Click(object sender, EventArgs e)
        {
            time = 180;
            f_go();
        }

        private void 快捷时间_4min_Click(object sender, EventArgs e)
        {
            time = 240;
            f_go();
        }

        private void 快捷时间_5min_Click(object sender, EventArgs e)
        {
            time = 300;
            f_go();
        }

        private void 时_TextChanged(object sender, EventArgs e)
        {
            if ((int.Parse(时.Text) <= 23) && (int.Parse(时.Text) >= 0))
            {
                time_时 = int.Parse(时.Text);
            }
        }

        private void 分_TextChanged(object sender, EventArgs e)
        {
            if ((int.Parse(分.Text) <= 59) && (int.Parse(分.Text) >= 0))
            {
                time_分 = int.Parse(分.Text);
            }
        }

        private void 秒_TextChanged(object sender, EventArgs e)
        {
            if ((int.Parse(秒.Text) <= 59) && (int.Parse(秒.Text) >= 0))
            {
                time_秒 = int.Parse(秒.Text);
            }
        }
    }
}
