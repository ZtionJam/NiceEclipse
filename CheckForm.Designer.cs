namespace NiceEclipse
{
    partial class CheckForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.alert = new System.Windows.Forms.Label();
            this.plan = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bgThread = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.alert);
            this.panel1.Controls.Add(this.plan);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 290);
            this.panel1.TabIndex = 0;
            // 
            // alert
            // 
            this.alert.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.alert.ForeColor = System.Drawing.Color.Green;
            this.alert.Location = new System.Drawing.Point(0, 235);
            this.alert.Name = "alert";
            this.alert.Size = new System.Drawing.Size(287, 32);
            this.alert.TabIndex = 1;
            this.alert.Text = "初始化...";
            this.alert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plan
            // 
            this.plan.animated = true;
            this.plan.animationIterval = 5;
            this.plan.animationSpeed = 10;
            this.plan.BackColor = System.Drawing.Color.White;
            this.plan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plan.BackgroundImage")));
            this.plan.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.plan.ForeColor = System.Drawing.Color.SeaGreen;
            this.plan.LabelVisible = true;
            this.plan.LineProgressThickness = 8;
            this.plan.LineThickness = 5;
            this.plan.Location = new System.Drawing.Point(60, 60);
            this.plan.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.plan.MaxValue = 100;
            this.plan.Name = "plan";
            this.plan.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.plan.ProgressColor = System.Drawing.Color.SeaGreen;
            this.plan.Size = new System.Drawing.Size(167, 167);
            this.plan.TabIndex = 0;
            this.plan.Value = 10;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 300;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 300;
            this.bunifuElipse2.TargetControl = this.panel1;
            // 
            // bgThread
            // 
            this.bgThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgThread_DoWork);
            this.bgThread.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgThread_RunWorkerCompleted);
            // 
            // CheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckForm";
            this.Load += new System.EventHandler(this.CheckForm_Load);
            this.Shown += new System.EventHandler(this.CheckForm_Shown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar plan;
        private System.Windows.Forms.Label alert;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.ComponentModel.BackgroundWorker bgThread;
    }
}