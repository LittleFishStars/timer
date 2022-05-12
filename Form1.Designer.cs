
namespace 计时器
{
    partial class 计时器
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(计时器));
            this.时 = new System.Windows.Forms.TextBox();
            this.分 = new System.Windows.Forms.TextBox();
            this.秒 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.快捷时间_5min = new System.Windows.Forms.Button();
            this.快捷时间_4min = new System.Windows.Forms.Button();
            this.快捷时间_3min = new System.Windows.Forms.Button();
            this.快捷时间_2min = new System.Windows.Forms.Button();
            this.快捷时间_1min = new System.Windows.Forms.Button();
            this.快捷时间_30s = new System.Windows.Forms.Button();
            this.秒_减 = new System.Windows.Forms.Button();
            this.分_减 = new System.Windows.Forms.Button();
            this.时_减 = new System.Windows.Forms.Button();
            this.秒_加 = new System.Windows.Forms.Button();
            this.分_加 = new System.Windows.Forms.Button();
            this.时_加 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.go = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 时
            // 
            this.时.BackColor = System.Drawing.Color.White;
            this.时.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.时, "时");
            this.时.Name = "时";
            this.时.TextChanged += new System.EventHandler(this.时_TextChanged);
            // 
            // 分
            // 
            this.分.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.分, "分");
            this.分.Name = "分";
            this.分.TextChanged += new System.EventHandler(this.分_TextChanged);
            // 
            // 秒
            // 
            this.秒.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.秒, "秒");
            this.秒.Name = "秒";
            this.秒.TextChanged += new System.EventHandler(this.秒_TextChanged);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.快捷时间_5min);
            this.groupBox1.Controls.Add(this.快捷时间_4min);
            this.groupBox1.Controls.Add(this.快捷时间_3min);
            this.groupBox1.Controls.Add(this.快捷时间_2min);
            this.groupBox1.Controls.Add(this.快捷时间_1min);
            this.groupBox1.Controls.Add(this.快捷时间_30s);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // 快捷时间_5min
            // 
            this.快捷时间_5min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(196)))), ((int)(((byte)(191)))));
            resources.ApplyResources(this.快捷时间_5min, "快捷时间_5min");
            this.快捷时间_5min.Name = "快捷时间_5min";
            this.快捷时间_5min.UseVisualStyleBackColor = false;
            this.快捷时间_5min.Click += new System.EventHandler(this.快捷时间_5min_Click);
            // 
            // 快捷时间_4min
            // 
            this.快捷时间_4min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(196)))), ((int)(((byte)(191)))));
            resources.ApplyResources(this.快捷时间_4min, "快捷时间_4min");
            this.快捷时间_4min.Name = "快捷时间_4min";
            this.快捷时间_4min.UseVisualStyleBackColor = false;
            this.快捷时间_4min.Click += new System.EventHandler(this.快捷时间_4min_Click);
            // 
            // 快捷时间_3min
            // 
            this.快捷时间_3min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(196)))), ((int)(((byte)(191)))));
            resources.ApplyResources(this.快捷时间_3min, "快捷时间_3min");
            this.快捷时间_3min.Name = "快捷时间_3min";
            this.快捷时间_3min.UseVisualStyleBackColor = false;
            this.快捷时间_3min.Click += new System.EventHandler(this.快捷时间_3min_Click);
            // 
            // 快捷时间_2min
            // 
            this.快捷时间_2min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(196)))), ((int)(((byte)(191)))));
            resources.ApplyResources(this.快捷时间_2min, "快捷时间_2min");
            this.快捷时间_2min.Name = "快捷时间_2min";
            this.快捷时间_2min.UseVisualStyleBackColor = false;
            this.快捷时间_2min.Click += new System.EventHandler(this.快捷时间_2min_Click);
            // 
            // 快捷时间_1min
            // 
            this.快捷时间_1min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(196)))), ((int)(((byte)(191)))));
            resources.ApplyResources(this.快捷时间_1min, "快捷时间_1min");
            this.快捷时间_1min.Name = "快捷时间_1min";
            this.快捷时间_1min.UseVisualStyleBackColor = false;
            this.快捷时间_1min.Click += new System.EventHandler(this.快捷时间_1min_Click);
            // 
            // 快捷时间_30s
            // 
            this.快捷时间_30s.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(196)))), ((int)(((byte)(191)))));
            resources.ApplyResources(this.快捷时间_30s, "快捷时间_30s");
            this.快捷时间_30s.Name = "快捷时间_30s";
            this.快捷时间_30s.UseVisualStyleBackColor = false;
            this.快捷时间_30s.Click += new System.EventHandler(this.快捷时间_30s_Click);
            // 
            // 秒_减
            // 
            this.秒_减.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(200)))), ((int)(((byte)(226)))));
            resources.ApplyResources(this.秒_减, "秒_减");
            this.秒_减.Name = "秒_减";
            this.秒_减.UseVisualStyleBackColor = false;
            this.秒_减.Click += new System.EventHandler(this.秒_减_Click);
            // 
            // 分_减
            // 
            this.分_减.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(200)))), ((int)(((byte)(226)))));
            resources.ApplyResources(this.分_减, "分_减");
            this.分_减.Name = "分_减";
            this.分_减.UseVisualStyleBackColor = false;
            this.分_减.Click += new System.EventHandler(this.分_减_Click);
            // 
            // 时_减
            // 
            this.时_减.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(200)))), ((int)(((byte)(226)))));
            resources.ApplyResources(this.时_减, "时_减");
            this.时_减.Name = "时_减";
            this.时_减.UseVisualStyleBackColor = false;
            this.时_减.Click += new System.EventHandler(this.时_减_Click);
            // 
            // 秒_加
            // 
            this.秒_加.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(200)))), ((int)(((byte)(226)))));
            resources.ApplyResources(this.秒_加, "秒_加");
            this.秒_加.Name = "秒_加";
            this.秒_加.UseVisualStyleBackColor = false;
            this.秒_加.Click += new System.EventHandler(this.秒_加_Click);
            // 
            // 分_加
            // 
            this.分_加.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(200)))), ((int)(((byte)(226)))));
            resources.ApplyResources(this.分_加, "分_加");
            this.分_加.Name = "分_加";
            this.分_加.UseVisualStyleBackColor = false;
            this.分_加.Click += new System.EventHandler(this.分_加_Click);
            // 
            // 时_加
            // 
            this.时_加.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(200)))), ((int)(((byte)(226)))));
            resources.ApplyResources(this.时_加, "时_加");
            this.时_加.Name = "时_加";
            this.时_加.UseVisualStyleBackColor = false;
            this.时_加.Click += new System.EventHandler(this.时_加_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // go
            // 
            this.go.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(136)))), ((int)(((byte)(253)))));
            resources.ApplyResources(this.go, "go");
            this.go.Name = "go";
            this.go.UseVisualStyleBackColor = false;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // 计时器
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(219)))), ((int)(((byte)(236)))));
            this.Controls.Add(this.go);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.秒);
            this.Controls.Add(this.分);
            this.Controls.Add(this.时);
            this.Controls.Add(this.秒_减);
            this.Controls.Add(this.分_减);
            this.Controls.Add(this.时_减);
            this.Controls.Add(this.秒_加);
            this.Controls.Add(this.分_加);
            this.Controls.Add(this.时_加);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "计时器";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(191)))), ((int)(((byte)(242)))));
            this.Load += new System.EventHandler(this.计时器_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 时_加;
        private System.Windows.Forms.Button 分_加;
        private System.Windows.Forms.Button 秒_加;
        private System.Windows.Forms.Button 时_减;
        private System.Windows.Forms.Button 分_减;
        private System.Windows.Forms.Button 秒_减;
        private System.Windows.Forms.TextBox 时;
        private System.Windows.Forms.TextBox 分;
        private System.Windows.Forms.TextBox 秒;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button 快捷时间_5min;
        private System.Windows.Forms.Button 快捷时间_4min;
        private System.Windows.Forms.Button 快捷时间_3min;
        private System.Windows.Forms.Button 快捷时间_2min;
        private System.Windows.Forms.Button 快捷时间_1min;
        private System.Windows.Forms.Button 快捷时间_30s;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button go;
    }
}

