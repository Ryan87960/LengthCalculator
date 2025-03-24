using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LengthCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 全域變數
        string strInput; // 字串型態的strInput變數
        double douOutput; // double浮點數型態的douOutput變數
        void caculateAnswer(int 參數1, double 參數2)
        {
            txtCM.Text = string.Format("{0:0.##########}", 參數2);
            txtM.Text = string.Format("{0:0.##########}", 參數2 / 100);
            txtKM.Text = string.Format("{0:0.##########}", 參數2 / 10000);
            txtIn.Text = string.Format("{0:0.##########}", 參數2 / 2.54);
            txtFt.Text = string.Format("{0:0.##########}", 參數2 / 30.48);
            txtYard.Text = string.Format("{0:0.##########}", 參數2 / 91.44);
        }
        private void txtCM_KeyUp(object sender, EventArgs e)
        {
            strInput = txtCM.Text; // 將txtCM文字框的值放入strInput變數
            

            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douOutput) == true)
            {
                
                //執行計算長度函式
                caculateAnswer(0, douOutput);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtCM文字框清除
                txtInfo.Text = "請輸入數字";
                txtCM.Text = "";
            }
        }

        private void txtM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtM.Text; // 將txtM文字框的值放入strInput變數
            if (double.TryParse(strInput, out douOutput) == true)
            {


                caculateAnswer(1, douOutput * 100); // 事先將公尺轉換成公分

            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtM.Text = "";
            }
        }

        private void txtKM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtKM.Text; // 將txtM文字框的值放入strInput變數
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(2, douOutput * 10000); // 事先將公里轉換成公分
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtKM.Text = "";
            }
        }

        private void txtIn_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtIn.Text; // 將txtM文字框的值放入strInput變數
            if (double.TryParse(strInput, out douOutput) == true)
         {
            caculateAnswer(3, douOutput * 2.54); // 事先將英吋轉換成公分
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtIn.Text = "";
            }
        }

        private void txtFt_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtFt.Text; // 將txtM文字框的值放入strInput變數
            if (double.TryParse(strInput, out douOutput) == true)
            {
               caculateAnswer(4, douOutput * 30.48); // 事先將英尺轉換成公分
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtFt.Text = "";
            }
        }

        private void txtYard_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtYard.Text; // 將txtM文字框的值放入strInput變數
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(5, douOutput * 91.44); // 事先將碼轉換成公分
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtYard.Text = "";
            }
        }

        private void btnAllClear_Click(object sender, EventArgs e)
        {
            txtCM.Text = "";
            txtM.Text = "";
            txtKM.Text = "";
            txtIn.Text = "";
            txtFt.Text = "";
            txtYard.Text = "";
        }
    }
}
