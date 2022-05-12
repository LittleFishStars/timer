
namespace 计时器
{
    partial class 计时
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(计时));
            this.l_时 = new System.Windows.Forms.Label();
            this.l_分 = new System.Windows.Forms.Label();
            this.l_秒 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // l_时
            // 
            this.l_时.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l_时.AutoSize = true;
            this.l_时.Font = new System.Drawing.Font("Century Gothic", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_时.ForeColor = System.Drawing.Color.White;
            this.l_时.Location = new System.Drawing.Point(83, 153);
            this.l_时.Name = "l_时";
            this.l_时.Size = new System.Drawing.Size(130, 93);
            this.l_时.TabIndex = 0;
            this.l_时.Text = "00";
            this.l_时.Click += new System.EventHandler(this.l_时_Click);
            // 
            // l_分
            // 
            this.l_分.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l_分.AutoSize = true;
            this.l_分.Font = new System.Drawing.Font("Century Gothic", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_分.ForeColor = System.Drawing.Color.White;
            this.l_分.Location = new System.Drawing.Point(287, 153);
            this.l_分.Name = "l_分";
            this.l_分.Size = new System.Drawing.Size(130, 93);
            this.l_分.TabIndex = 1;
            this.l_分.Text = "00";
            // 
            // l_秒
            // 
            this.l_秒.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l_秒.AutoSize = true;
            this.l_秒.Font = new System.Drawing.Font("Century Gothic", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_秒.ForeColor = System.Drawing.Color.White;
            this.l_秒.Location = new System.Drawing.Point(491, 153);
            this.l_秒.Name = "l_秒";
            this.l_秒.Size = new System.Drawing.Size(130, 93);
            this.l_秒.TabIndex = 2;
            this.l_秒.Text = "00";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(219, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 93);
            this.label1.TabIndex = 3;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(423, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 93);
            this.label2.TabIndex = 4;
            this.label2.Text = ":";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // 计时
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(698, 400);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l_秒);
            this.Controls.Add(this.l_分);
            this.Controls.Add(this.l_时);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "计时";
            this.Text = "时间";
            this.Load += new System.EventHandler(this.计时_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_时;
        private System.Windows.Forms.Label l_分;
        private System.Windows.Forms.Label l_秒;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}