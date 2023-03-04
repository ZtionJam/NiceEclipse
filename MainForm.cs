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
using CCWin;
using System.Net;

namespace NiceEclipse
{
    public partial class MainForm : SkinMain
    {
        #region 字段
        private string toPath = null, picPath = null;
        private Boolean isPicOK = false;
        int[] tmp = new int[1000];
        int fori = 0;
        #endregion

        #region 构造
        public MainForm(string path)
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            toPath = path;
            SetPath();

        }
        #endregion

        #region    数据流转图片 ReadURLImageToStream(string URLimage)
        Image ReadURLImageToStream(string URLimage)
        {
            try
            {
                Uri uri = new Uri(URLimage);
                WebRequest req = WebRequest.Create(uri);
                WebResponse resp = req.GetResponse();
                Stream str = resp.GetResponseStream();
                Image img = Image.FromStream(str);
                return img;
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
                return null;
            }

        }
        #endregion

        #region 手动选择安装目录设置
        public void SetPath()
        {
            if (string.IsNullOrEmpty(toPath))
            {
                this.Hide();
                if (new TW("你的Eclipse配置文件不在默认目录，请点击确定手动选择eclipse安装目录", "提示").ShowDialog() == DialogResult.OK)
                {
                    FolderBrowserDialog dialog = new FolderBrowserDialog();
                    dialog.Description = "选择Eclipse的安装目录....";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        if (string.IsNullOrEmpty(dialog.SelectedPath))
                        {
                            if (new TW("您未选择任何文件夹，程序即将退出", "提示").ShowDialog() == DialogResult.OK)
                            {
                                Thread.Sleep(300);
                                Application.Exit();
                            }
                        }
                        toPath = dialog.SelectedPath + @"\plugins";
                        if (!Directory.Exists(toPath))
                        {
                            if (new TW("文件夹不正确，请重新打开软件重新选择目录", "文件夹不正确").ShowDialog() == DialogResult.OK)
                            {
                                Application.Exit();
                            }
                        }
                        GetPath(toPath);
                        BackCss();
                    }
                }
            }
            this.Show();
        }
        #endregion

        #region 备份样式表
        public void BackCss()
        {
            string css = toPath + @"\e4_basestyle.css";
            if (File.Exists(css))
            {
                if (!File.Exists(toPath + @"\NiceEclipseBacku.css"))
                {
                    File.Copy(css, toPath + @"\NiceEclipseBacku.css");
                }
            }
        }
        #endregion

        #region 获取包含字符串的目录名
        private void GetPath(string fPath)
        {
            DirectoryInfo oPath = new DirectoryInfo(fPath);
            DirectoryInfo[] aPath = oPath.GetDirectories();
            foreach (DirectoryInfo item in aPath)
            {
                if (item.Name.IndexOf("org.eclipse.ui.themes") >= 0)
                {
                    //realPath = fPath;
                    toPath += "\\" + item.Name + "\\css";
                    //MessageBox.Show(realPath);
                    return;
                }
            }

        }
        #endregion

        #region 加载事件
        private void Form1_Load(object sender, EventArgs e)
        {


            Thread.Sleep(500);
            GetDefault();
            Win32.AnimateWindow(this.Handle, 200, Win32.AW_VER_POSITIVE);
            this.lbver.Text = "Ver." + Online.thisver;
            DeleteFolder(toPath + @"\tmp");

        }
        private void MainForm_Shown(object sender, EventArgs e)
        {
            this.bgup.RunWorkerAsync();
        }
        #endregion

        #region 清空文件夹
        public static void DeleteFolder(string path)
        {
            try
            {
                foreach (string d in Directory.GetFileSystemEntries(path))
                {
                    if (File.Exists(d))
                    {
                        FileInfo fi = new FileInfo(d);
                        if (fi.Attributes.ToString().IndexOf("ReadOnly") != -1)
                            fi.Attributes = FileAttributes.Normal;
                        File.Delete(d);
                    }
                    else
                    {
                        DirectoryInfo d1 = new DirectoryInfo(d);
                        if (d1.GetFiles().Length != 0)
                        {
                            DeleteFolder(d1.FullName);
                        }
                        Directory.Delete(d);
                    }
                }
            }
            catch (Exception e)
            {
            }
        }
        #endregion

        #region 窗体移动
        Boolean isDown = false;
        int x = 0, y = 0;
        private void Title_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
            x = e.X;
            y = e.Y;
        }

        private void Title_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
        }

        private void Title_MouseMove(object sender, MouseEventArgs e)
        {
            //int x = this.Location.X, y = this.Location.Y;
            if (isDown)
            {
                this.Location = new Point((this.Location.X + e.X - x), (this.Location.Y + e.Y - y));
            }
        }
        #endregion

        #region 判断是否兼容Eclipse版本
        public void IsOK()
        {

            if (Directory.Exists(toPath))
            {

            }
        }




        #endregion

        #region 按钮样式 
        private void label1_Click(object sender, EventArgs e)
        {
            new TW("当前安装目录:" + toPath, "安装目录").Show();
        }
        private void BtnChoose_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackgroundImage = global::NiceEclipse.Properties.Resources.按钮;
        }

        private void BtnChoose_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackgroundImage = global::NiceEclipse.Properties.Resources.按2;

        }
        private void Button1_Click_1(object sender, EventArgs e)
        {
            TW tw = new TW("确认退出？", "Sure?");
            if (tw.ShowDialog() == DialogResult.OK)
            {
                DeleteFolder(toPath + @"\tmp");
                Application.Exit();
            }
        }

        #endregion

        #region 加载当前背景
        public void GetDefault()
        {
            if (File.Exists(toPath + @"\Default.txt"))
            {
                ECBack.Image = global::NiceEclipse.Properties.Resources.未设置背景;
                return;
            }

            Random rand = new Random();
            int n = rand.Next(1, 1000000000);
            string pic = toPath + @"\tmp\" + n + ".jpg";
            Directory.CreateDirectory(toPath + @"\tmp");
            try
            {
                File.Copy(toPath + @"\1.jpg", pic);
            }
            catch (Exception e)
            {

                new TW("恭喜你踩中了只有十亿分之一几率的BUG，请重启一下软件就好了", "出现BUG", 1);
            }
            //pic = toPath + @"\tmp.jpg";
            if (File.Exists(pic))
            {
                ECBack.Image = Image.FromFile(pic);
                //fori++;
            }



        }
        #endregion

        #region 选择文件
        Image ima;
        private void BtnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Title = "请选择一张图片哇";
            fileDialog.Filter = "所有文件(*jpg*)|*.jpg*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = fileDialog.FileName;
                picPath = path;
                lbFilename.Text = "..." + picPath.Substring(path.Length - 10, 10);
                ima = Image.FromFile(picPath);
                picOK.Image = ima;
                isPicOK = true;
            }
            fileDialog.Dispose();

        }
        #endregion

        #region 设置背景
        private void BtnSetNow_Click(object sender, EventArgs e)
        {
            if (isPicOK)
            {
                if (File.Exists(picPath))
                {
                    new FileInfo(picPath).Attributes = FileAttributes.Normal;
                    if (new TW("是否立即设置？(双击标题可以取消)", "提示", 2).ShowDialog() == DialogResult.OK)
                    {
                        if (toDefault() && SetCSS())
                        {
                            new TW("更换完成了，快去看看吧", "成功").Show();
                            if (!File.Exists(@"C:\Users\" + Environment.UserName + @"\NEBak\Log.txt"))
                            {
                                SavePath();
                            }
                        }
                        else
                        {
                            new TW("失败了,你可以重新试试+er.Message", "失败").Show();
                        }
                        File.Delete(toPath + @"\1.jpg");
                        File.Copy(picPath, toPath + @"\1.jpg");
                        //File.Delete(toPath + @"\Default.txt");
                        GetDefault();
                    }
                }
            }
            else
            {
                new TW("你还没有选择图片哦，快点去选择吧", "提示", 1).Show();
            }
        }


        #endregion

        #region 编辑样式表
        public Boolean SetCSS()
        {
            if (File.Exists(toPath + @"\Default.txt"))
                File.Delete(toPath + @"\Default.txt");
            try
            {
                string css = toPath + @"\e4_basestyle.css";
                string[] str = File.ReadAllLines(css, Encoding.UTF8);
                string newCss = null;
                foreach (string item in str)
                {
                    newCss += item + "\r\n";
                    if (item.IndexOf(@"{") > 0)
                    {
                        newCss += "\t" + @"background-image: url(./1.jpg);" + "\r\n";
                    }
                }
                newCss += "\r\n" + @".MPart StyledText { background-image: url(./1.jpg); background-color: white; background-position: no-repeat; color: black; }";
                File.WriteAllText(toPath + @"\e4_basestyle.css", newCss);
                return true;
            }
            catch (Exception e)
            {
                new TW("更换失败请重试，错误原因" + e.Message, "失败").Show();
                return false;
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            SetCSS();
            new TW("回复完成", "成功了").Show();
        }
        #endregion

        #region 恢复默认
        private void BtnReSet_Click(object sender, EventArgs e)
        {
            if (toDefault())
            {
                new TW("回复完成", "成功了").Show();
            }
            else
            {
                new TW("恢复失败，请重试", "恢复失败").Show();
            }
        }


        public Boolean toDefault()
        {
            if (File.Exists(toPath + @"\NiceEclipseBacku.css"))
            {
                //MessageBox.Show("找到了");
                try
                {
                    File.Copy(toPath + @"\NiceEclipseBacku.css", toPath + @"\e4_basestyle.css", true);

                    File.WriteAllText(toPath + @"\Default.txt", "NiceEclipse Cache\r\nDon·t Delete");
                    GetDefault();
                    return true;
                }
                catch (Exception er)
                {
                    new TW("出现一个错误，请重试,错误原因:" + er.Message, "恢复失败").Show();
                }
            }
            return false;
        }


        #endregion

        #region 检查更新
        private void Bgup_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (Convert.ToDouble(Online.mustup) > Convert.ToDouble(Online.thisver))
            {
                TW tw = new TW("强制更新:当前最新版:" + Online.newver + ",正在运行的版本" + Online.thisver + ",你的版本过于古老,点击确认更新", "更新提示");
                if (tw.ShowDialog() == DialogResult.OK)
                {
                    System.Diagnostics.Process.Start(Online.newapp);
                    Application.Exit();
                }
            }
            if (Convert.ToDouble(Online.newver) > Convert.ToDouble(Online.thisver))
            {
                TW tw = new TW("可选更新:当前最新版:" + Online.newver + ",正在运行的版本" + Online.thisver + ",新版功能:" + Online.upinfo + ",点击确认键即可更新，双击标题取消", "更新提示");
                if (tw.ShowDialog() == DialogResult.OK)
                {
                    System.Diagnostics.Process.Start(Online.newapp);
                    //Application.Exit();
                }
            }
        }



        public void CheckUp()
        {
            Online.GetUp();

        }



        private void Bgup_DoWork(object sender, DoWorkEventArgs e)
        {
            //Thread.Sleep(2000);
            CheckUp();
            if (Online.hasNet)
            {
                picmyhead.Image = ReadURLImageToStream(Online.headimg);
            }
        }


        #endregion

        #region 使用内置壁纸
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            Image img = pic.Image;
            Random rand = new Random();
            Bitmap bm = new Bitmap(img);
            int rn = rand.Next(0, 1000000000);
            picPath = toPath + @"\tmp\" + rn + ".jpg";
            try
            {
                bm.Save(picPath);
                isPicOK = true;
                picOK.Image = Image.FromFile(picPath);
                lbFilename.Text = "已选择内置壁纸";
            }
            catch (Exception er)
            {
                new TW("你出触发了几率极小的BUG，请重试或重启软件:" + er.Message, "发生BUG").Show();
            }
        }
        #endregion

        #region 跳转博客
        private void Picmyhead_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://blog.ztion.top");
        }
        #endregion

        #region 保存已找到的目录
        public void SavePath()
        {
            string pathBak = @"C:\Users\" + Environment.UserName + @"\NEBak";
            string pathContent =toPath;
            try
            {
                Directory.CreateDirectory(pathBak);
                File.WriteAllText(pathBak + "\\Log.txt", pathContent);
            }
            catch (Exception er)
            {
                new TW("出现错误，来自目录备份时：" + er.Message, "出现错误").Show();
            }
        }
        #endregion
    }

}
