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
    public partial class Form_Post : Form
    {
        Form1 Form1_ref;
        public Form_Post(Form1 Temp)
        {
            InitializeComponent();
            Form1_ref = Temp;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
        }

        private void Form_Post_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確認返回？", "返回", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1_ref.Form_Home.Show(Form1_ref);
                reset();
                this.Hide();
            }
        }

        private void Btn_Post_Click(object sender, EventArgs e)
        {
            if (txt_topic.Text == "")
                MessageBox.Show("標題不能為空", "發文失敗");
            else if (txt_inside.Text == "")
                MessageBox.Show("內容不能為空", "發文失敗");
            else
            {
                if (MessageBox.Show("確認發文？", "發文", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Article article = new Article(txt_topic.Text,txt_inside.Text,Form1_ref.ID);
                    if (CBox_Hurry.Checked == true)
                        article.Top = true;
                    Form1_ref.K_S.Request(KcardRequest.Add_Article + article.ToString());
                    Form1_ref.Form_Home.addhome();
                    Form1_ref.Form_Home.Show(Form1_ref);
                    reset();
                    this.Hide();
                }
            }
        }
        public void reset()
        {
            CBox_Hurry.Checked = false;
            txt_inside.Clear();
            txt_topic.Clear();
        }
    }
}
