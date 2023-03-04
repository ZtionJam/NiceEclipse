using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace NiceEclipse
{
    public partial class CheckForm : Form
    {
        #region 字段
        private string fPath = null, realPath = null;
        private string needName = @"org.eclipse.ui.themes";
        #endregion

        #region 构造
        public CheckForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        #endregion

        #region 加载事件
        private void CheckForm_Load(object sender, EventArgs e)
        {
            fPath = @"C:\Users\" + Environment.UserName + @"\.p2\pool\plugins";
        }
        #endregion

        #region 窗体加载完成事件

        private void CheckForm_Shown(object sender, EventArgs e)
        {
            this.bgThread.RunWorkerAsync();
        }
        #endregion

        #region 检测
        private void GetSuffix()
        {
           
            if (File.Exists(@"C:\Users\" + Environment.UserName + @"\NEBak\Log.txt"))
            {
                alert.Text = "目录已设定，正在加载主界面";
                plan.Value = 100;
                Thread.Sleep(500);
                realPath = File.ReadAllText(@"C:\Users\" + Environment.UserName + @"\NEBak\Log.txt");
                return;
            }
            if (Directory.Exists(fPath))
            {
                //形式主义
                plan.Value = 20;
                alert.Text = "检测目录...";
                Thread.Sleep(500);
                GetPath(needName);
                if (!string.IsNullOrEmpty(realPath))
                {
                    plan.Value = 50;
                    alert.Text = "生成目录...";
                    Thread.Sleep(500);
                    realPath += @"\css";

                    string css = realPath + @"\e4_basestyle.css";
                    if (File.Exists(css))
                    {
                        if (!File.Exists(realPath + @"\NiceEclipseBacku.css"))
                        {
                            File.Copy(css, realPath + @"\NiceEclipseBacku.css");
                        }
                    }
                    else
                    {
                        ShowErr();
                    }
                    plan.Value = 80;
                    alert.Text = "备份样式表...";
                    Thread.Sleep(500);
                    plan.Value = 100;
                    alert.Text = "检测通过!正在打开主界面...";
                    Thread.Sleep(500);
                    //CallBack stop = obj as CallBack;
                    //stop();
                }
                else
                {
                    ShowErr();
                }
            }
            else
            {
                realPath = null;
                plan.Value = 20;
                Thread.Sleep(300);
                alert.Text = "需要手动选择目录";
                plan.Value = 60;
                Thread.Sleep(300);
                plan.Value = 80;
                Thread.Sleep(300);
                plan.Value = 100;
            }
        }
        #endregion

        #region 不兼容处理
        public void ShowErr()
        {
            new TW("软件不兼容你的eclipse，请尝试更新eclipse或重启软件", "检测不通过", 1).Show();
            Thread.Sleep(3000);
            Application.Exit();
        }
        #endregion

        #region 线程回调 OLD
        private void OpenForm()
        {
            MainForm frm = new MainForm(realPath);
            //this.Hide();
            Application.Run(frm);
            //frm.Show();

        }


        #endregion

        #region 获取包含字符串的目录名
        private void GetPath(string str)
        {
            DirectoryInfo oPath = new DirectoryInfo(fPath);
            DirectoryInfo[] aPath = oPath.GetDirectories();
            foreach (DirectoryInfo item in aPath)
            {
                if (item.Name.IndexOf(str) >= 0)
                {
                    realPath = fPath;
                    realPath += "\\" + item.Name;
                    //MessageBox.Show(realPath);
                    return;
                }
            }

        }
        #endregion

        #region 后台线程
        private void BgThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            MainForm frm = new MainForm(realPath);
            this.Hide();
            //Application.Run(frm);
            frm.Show();
        }

        private void BgThread_DoWork(object sender, DoWorkEventArgs e)
        {
            GetSuffix();
        }
        #endregion
    }
}
