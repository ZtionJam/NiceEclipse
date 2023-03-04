namespace NiceEclipse
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.title = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbver = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.picmyhead = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbFilename = new System.Windows.Forms.Label();
            this.ls = new System.Windows.Forms.Label();
            this.bgup = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnReSet = new System.Windows.Forms.Button();
            this.btnSetNow = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.picOK = new System.Windows.Forms.PictureBox();
            this.ECBack = new System.Windows.Forms.PictureBox();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.title.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmyhead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ECBack)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.title.Controls.Add(this.label1);
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Margin = new System.Windows.Forms.Padding(2);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(792, 40);
            this.title.TabIndex = 0;
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_MouseDown);
            this.title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Title_MouseMove);
            this.title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Title_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(344, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "NiceEclipse";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbver);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.picmyhead);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(257, 65);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 355);
            this.panel1.TabIndex = 3;
            // 
            // lbver
            // 
            this.lbver.AutoSize = true;
            this.lbver.BackColor = System.Drawing.Color.Transparent;
            this.lbver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbver.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbver.ForeColor = System.Drawing.Color.Gray;
            this.lbver.Location = new System.Drawing.Point(417, 214);
            this.lbver.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbver.Name = "lbver";
            this.lbver.Size = new System.Drawing.Size(41, 16);
            this.lbver.TabIndex = 1;
            this.lbver.Text = "Ver.0.5";
            this.toolTip1.SetToolTip(this.lbver, "软件通过修改eclipse样式表达到效果，由于作者比较懒，所以直接每个项都添加了背景，以后的版本可能会分析样式表。软件不支持太过远古的eclipse版本。");
            this.lbver.Click += new System.EventHandler(this.Picmyhead_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(142, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 1);
            this.panel4.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(392, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "NiceEclipse";
            this.toolTip1.SetToolTip(this.label2, "软件通过修改eclipse样式表达到效果，由于作者比较懒，所以直接每个项都添加了背景，以后的版本可能会分析样式表。软件不支持太过远古的eclipse版本。");
            this.label2.Click += new System.EventHandler(this.Picmyhead_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::NiceEclipse.Properties.Resources.按2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(408, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 20);
            this.button1.TabIndex = 5;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            this.button1.MouseEnter += new System.EventHandler(this.BtnChoose_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.BtnChoose_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::NiceEclipse.Properties.Resources._2f926567f53135a3ddddd1918f829073;
            this.pictureBox3.Location = new System.Drawing.Point(8, 240);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(166, 103);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::NiceEclipse.Properties.Resources._5e9ac6e7afe2197dbd26575f4f485bbd;
            this.pictureBox2.Location = new System.Drawing.Point(8, 124);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(166, 103);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = global::NiceEclipse.Properties.Resources.d793d82924d39de4388ad96f6459dd81;
            this.pictureBox6.Location = new System.Drawing.Point(197, 240);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(166, 103);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 2;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // picmyhead
            // 
            this.picmyhead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picmyhead.Image = global::NiceEclipse.Properties.Resources.压缩后;
            this.picmyhead.Location = new System.Drawing.Point(397, 105);
            this.picmyhead.Margin = new System.Windows.Forms.Padding(2);
            this.picmyhead.Name = "picmyhead";
            this.picmyhead.Size = new System.Drawing.Size(80, 80);
            this.picmyhead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picmyhead.TabIndex = 2;
            this.picmyhead.TabStop = false;
            this.toolTip1.SetToolTip(this.picmyhead, "软件通过修改eclipse样式表达到效果，由于作者比较懒，所以直接每个项都添加了背景，以后的版本可能会分析样式表。软件不支持太过远古的eclipse版本。");
            this.picmyhead.Click += new System.EventHandler(this.Picmyhead_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::NiceEclipse.Properties.Resources._2;
            this.pictureBox5.Location = new System.Drawing.Point(197, 124);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(166, 103);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::NiceEclipse.Properties.Resources.d8257e5923de60fcd7c44510402dd2e7;
            this.pictureBox4.Location = new System.Drawing.Point(197, 9);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(166, 103);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::NiceEclipse.Properties.Resources._462b5128bdd67272686fb8b011700d30;
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(412, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "内置壁纸";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(26, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "当前Eclipse背景:";
            // 
            // lbFilename
            // 
            this.lbFilename.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbFilename.Location = new System.Drawing.Point(33, 215);
            this.lbFilename.Name = "lbFilename";
            this.lbFilename.Size = new System.Drawing.Size(110, 21);
            this.lbFilename.TabIndex = 6;
            this.lbFilename.Text = "请选择文件...";
            // 
            // ls
            // 
            this.ls.AutoSize = true;
            this.ls.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ls.Location = new System.Drawing.Point(26, 239);
            this.ls.Name = "ls";
            this.ls.Size = new System.Drawing.Size(96, 20);
            this.ls.TabIndex = 6;
            this.ls.Text = "已选择的图片:";
            // 
            // bgup
            // 
            this.bgup.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Bgup_DoWork);
            this.bgup.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Bgup_RunWorkerCompleted);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            // 
            // btnReSet
            // 
            this.btnReSet.BackColor = System.Drawing.Color.Transparent;
            this.btnReSet.BackgroundImage = global::NiceEclipse.Properties.Resources.按2;
            this.btnReSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReSet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnReSet.FlatAppearance.BorderSize = 0;
            this.btnReSet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReSet.Font = new System.Drawing.Font("微软雅黑 Light", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReSet.Location = new System.Drawing.Point(40, 398);
            this.btnReSet.Name = "btnReSet";
            this.btnReSet.Size = new System.Drawing.Size(76, 28);
            this.btnReSet.TabIndex = 5;
            this.btnReSet.Text = "恢复官方";
            this.btnReSet.UseVisualStyleBackColor = false;
            this.btnReSet.Click += new System.EventHandler(this.BtnReSet_Click);
            this.btnReSet.MouseEnter += new System.EventHandler(this.BtnChoose_MouseEnter);
            this.btnReSet.MouseLeave += new System.EventHandler(this.BtnChoose_MouseLeave);
            // 
            // btnSetNow
            // 
            this.btnSetNow.BackColor = System.Drawing.Color.Transparent;
            this.btnSetNow.BackgroundImage = global::NiceEclipse.Properties.Resources.按2;
            this.btnSetNow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetNow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetNow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSetNow.FlatAppearance.BorderSize = 0;
            this.btnSetNow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSetNow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSetNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetNow.Font = new System.Drawing.Font("微软雅黑 Light", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSetNow.Location = new System.Drawing.Point(136, 398);
            this.btnSetNow.Name = "btnSetNow";
            this.btnSetNow.Size = new System.Drawing.Size(76, 28);
            this.btnSetNow.TabIndex = 5;
            this.btnSetNow.Text = "立即设置";
            this.btnSetNow.UseVisualStyleBackColor = false;
            this.btnSetNow.Click += new System.EventHandler(this.BtnSetNow_Click);
            this.btnSetNow.MouseEnter += new System.EventHandler(this.BtnChoose_MouseEnter);
            this.btnSetNow.MouseLeave += new System.EventHandler(this.BtnChoose_MouseLeave);
            // 
            // btnChoose
            // 
            this.btnChoose.BackColor = System.Drawing.Color.Transparent;
            this.btnChoose.BackgroundImage = global::NiceEclipse.Properties.Resources.按2;
            this.btnChoose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChoose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnChoose.FlatAppearance.BorderSize = 0;
            this.btnChoose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnChoose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoose.Font = new System.Drawing.Font("微软雅黑 Light", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChoose.Location = new System.Drawing.Point(149, 210);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(76, 28);
            this.btnChoose.TabIndex = 5;
            this.btnChoose.Text = "选择图片";
            this.btnChoose.UseVisualStyleBackColor = false;
            this.btnChoose.Click += new System.EventHandler(this.BtnChoose_Click);
            this.btnChoose.MouseEnter += new System.EventHandler(this.BtnChoose_MouseEnter);
            this.btnChoose.MouseLeave += new System.EventHandler(this.BtnChoose_MouseLeave);
            // 
            // picOK
            // 
            this.picOK.Image = global::NiceEclipse.Properties.Resources.未选择图片;
            this.picOK.Location = new System.Drawing.Point(28, 263);
            this.picOK.Margin = new System.Windows.Forms.Padding(2);
            this.picOK.Name = "picOK";
            this.picOK.Size = new System.Drawing.Size(197, 126);
            this.picOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOK.TabIndex = 2;
            this.picOK.TabStop = false;
            // 
            // ECBack
            // 
            this.ECBack.Image = global::NiceEclipse.Properties.Resources.未设置背景;
            this.ECBack.Location = new System.Drawing.Point(30, 74);
            this.ECBack.Margin = new System.Windows.Forms.Padding(2);
            this.ECBack.Name = "ECBack";
            this.ECBack.Size = new System.Drawing.Size(197, 126);
            this.ECBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ECBack.TabIndex = 2;
            this.ECBack.TabStop = false;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 80;
            this.bunifuElipse2.TargetControl = this.picmyhead;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(236, 418);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 1);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(250, 182);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 250);
            this.panel3.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Location = new System.Drawing.Point(629, 53);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 250);
            this.panel5.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(790, 450);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ls);
            this.Controls.Add(this.btnReSet);
            this.Controls.Add(this.btnSetNow);
            this.Controls.Add(this.lbFilename);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picOK);
            this.Controls.Add(this.ECBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(790, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(790, 450);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.title.ResumeLayout(false);
            this.title.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmyhead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ECBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel title;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ECBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Label lbFilename;
        private System.Windows.Forms.Label ls;
        private System.Windows.Forms.Button btnSetNow;
        private System.Windows.Forms.PictureBox picOK;
        private System.Windows.Forms.Button btnReSet;
        private System.ComponentModel.BackgroundWorker bgup;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox picmyhead;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbver;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
    }
}

