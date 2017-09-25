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
    public partial class Form_Assign : Form
    {
        Form1 Form1_ref;
        
        public Form_Assign(Form1 Temp)
        {
            InitializeComponent();
            Form1_ref = Temp;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            txt_password.PasswordChar = '*';
            txt_checkpassword.PasswordChar = '*';
            txt_peopleID.MaxLength = 10;
            txt_ID.MaxLength = 16;
            txt_password.MaxLength = 16;
            txt_checkpassword.MaxLength = 16;
        }

        private void Form_Assign_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Btn_assign_Click(object sender, EventArgs e)
        {
            //檢查是否有空格子
            if (txt_peopleID.Text == "")
                MessageBox.Show("身份證字號不可為空", "註冊失敗");
            else if (txt_ID.Text == "")
                MessageBox.Show("暱稱不可為空", "註冊失敗");
            else if (txt_password.Text == "")
                MessageBox.Show("密碼不可為空", "註冊失敗");
            else if (txt_checkpassword.Text != txt_password.Text)
                MessageBox.Show("確認密碼與密碼不相同", "註冊失敗");

            //沒空格子就檢查是否重複身分證字號及暱稱
            else
            {
                string Re_ID = Form1_ref.K_S.Request(KcardRequest.Search_ID + txt_peopleID.Text);//檢查身分證字號
                if (Re_ID == "null")//空為沒有重複
                {
                    string Re = Form1_ref.K_S.Request(KcardRequest.Search_User + txt_ID.Text);//檢查暱稱
                    if (Re == "null")//空為沒有重複
                    {
                        DialogResult result = MessageBox.Show("確認註冊？", "註冊", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            //確認身分
                            int who = 0;
                            if (RBtn_Student.Checked == true)
                                who = 1;
                            else if (RBtn_Teacher.Checked == true)
                                who = 2;
                            else if (RBtn_Worker.Checked == true)
                                who = 3;
                            //註冊
                            Form1_ref.K_S.Request((KcardRequest.Create_User + txt_ID.Text + "/" + txt_password.Text + "/" + txt_peopleID.Text + "/" + who));
                            Form1_ref.Form_Login.Show();
                            reset();
                            this.Hide();
                        }
                        else { }
                    }
                    else
                        MessageBox.Show("此暱稱已有人使用", "註冊失敗");
                }
                else
                    MessageBox.Show("此身份證字號已註冊過", "註冊失敗");
                
            }
        }
        public void reset()
        {
            txt_checkpassword.Clear();
            txt_ID.Clear();
            txt_password.Clear();
            txt_peopleID.Clear();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確認返回？", "返回", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1_ref.Form_Login.Show(Form1_ref);
                reset();
                this.Hide();
            }
        }
    }
}
