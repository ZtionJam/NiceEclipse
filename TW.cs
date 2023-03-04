using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NiceEclipse
{
    public partial class TW : SkinMain
    {

        #region 字段
        #region OLD
        //const int CS_DropSHADOW = 0x20000;
        //const int GCL_STYLE = (-26);
        //[DllImport("user32.dll", CharSet = CharSet.Auto)]
        //public static extern int SetClassLong(IntPtr hwnd, int nIndex, int dwNewLong);
        //[DllImport("user32.dll", CharSet = CharSet.Auto)]
        //public static extern int GetClassLong(IntPtr hwnd, int nIndex);
        //SetClassLong(this.Handle, GCL_STYLE, GetClassLong(this.Handle, GCL_STYLE) | CS_DropSHADOW);调用
        #endregion
        private string content = null,title=null;
        private int num=0;

        #endregion

        #region 构造
        public TW()
        {
            InitializeComponent();

        }
        public TW(String cont,string title,int num)
        {
            InitializeComponent();
            content = cont;
            this.num = num;
            this.title = title;

        }
        public TW(String cont,string titie)
        {
            InitializeComponent();
            content = cont;
            //this.num = num;
            this.title = titie;

        }
        #endregion

        #region 加载事件
        private void TW_Load(object sender, EventArgs e)
        {
            lbcontent.Text = content;
            label1.Text = title;

            Win32.AnimateWindow(this.Handle, 200, Win32.AW_VER_POSITIVE);

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

        #region 按钮样式 
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

        private void Label1_DoubleClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void BtnNO_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        

        private void BtnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        

        


        #endregion

      
    }
    #region Win32窗口动画
    public class Win32
    {
        public const Int32 AW_HOR_POSITIVE = 0x00000001;    // 从左到右打开窗口
        public const Int32 AW_HOR_NEGATIVE = 0x00000002;    // 从右到左打开窗口
        public const Int32 AW_VER_POSITIVE = 0x00000004;    // 从上到下打开窗口
        public const Int32 AW_VER_NEGATIVE = 0x00000008;    // 从下到上打开窗口
        public const Int32 AW_CENTER = 0x00000010;
        public const Int32 AW_HIDE = 0x00010000;        // 在窗体卸载时若想使用本函数就得加上此常量
        public const Int32 AW_ACTIVATE = 0x00020000;    //在窗体通过本函数打开后，默认情况下会失去焦点，除非加上本常量
        public const Int32 AW_SLIDE = 0x00040000;
        public const Int32 AW_BLEND = 0x00080000;       // 淡入淡出效果
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool AnimateWindow(
        IntPtr hwnd, // handle to window   
        int dwTime, // duration of animation   
        int dwFlags // animation type   
        );
    }
    #endregion
}
