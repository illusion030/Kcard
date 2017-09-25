using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kcard_class;

namespace KCARD
{
    public partial class Form_Login : Form
    {
        Form1 Form1_ref;
        public Form_Login(Form1 Temp)
        {
            InitializeComponent();
            Form1_ref = Temp;
            txt_password.PasswordChar = '*';
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
        }

        private void Btn_Assign_Click(object sender, EventArgs e)
        {
            Form1_ref.Form_Assign.Show(Form1_ref);
            reset();
            this.Hide();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            string Re = Form1_ref.K_S.Request((KcardRequest.Search_User + txt_account.Text));
            if (txt_account.Text == "87" && txt_password.Text == "87")
                {
                    Form1_ref.Form_Back.Show(Form1_ref);
                    reset();
                    this.Hide();
                }
            else if (Re == "null")
                MessageBox.Show("無此帳號", "登入失敗");
            else
            {
                int front = Re.IndexOf('/');
                string str = Re.Remove(front);
                string who = "";
                //string who = str.Substring(Re.IndexOf('/',(Re.IndexOf('/',(Re.IndexOf('/')+1)))));
                switch (who)
                {
                    case "1": Form1_ref.who = "學生"; break;
                    case "2": Form1_ref.who = "教授"; break;
                    case "3": Form1_ref.who = "行政人員"; break;
                    default : break;
                }
                if (txt_password.Text != str)
                {
                    MessageBox.Show("密碼錯誤！", "登入失敗");
                    txt_password.Clear();
                }
                else if (txt_password.Text == str)
                {
                    Form1_ref.ID = txt_account.Text;
                    Form1_ref.Form_Home.Show(Form1_ref);
                    Form1_ref.Form_Home.addhome();
                    reset();
                    this.Hide();
                }
            }
        }
        private void Form_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Form1_ref.close == false)
            {
                if (MessageBox.Show("你確定要關閉程式嗎？", "關閉程式", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    e.Cancel = true;
                else
                {
                    Form1_ref.close = true;
                    Application.Exit();
                }
            }    
        }
        public void reset()
        {
            txt_account.Clear();
            txt_password.Clear();
        }
    }
}
