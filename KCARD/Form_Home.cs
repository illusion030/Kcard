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
    public partial class Form_Home : Form
    {
        Form1 Form1_ref;
        string title;
        public Form_Home(Form1 Temp)
        {
            InitializeComponent();
            Form1_ref = Temp;
            
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            Btn_Back.Text = "登出";
            addhome();
            txt_comment.Visible = false;
        }
        private void Form_Home_FormClosing(object sender, FormClosingEventArgs e)
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
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Btn_post.Text == "發文" && (string)listBox1.SelectedItem!=null)
            {
                if ((string)listBox1.SelectedItem != "-------------------------------------------------------------------" && (string)listBox1.SelectedItem != "置頂文章-----------------------------------------------------------------")
                {
                    title = (string)listBox1.SelectedItem;
                    addpost(Form1_ref.K_S.Request(KcardRequest.Search_Article + title));
                }
            }
            
        }

        private void Btn_post_Click(object sender, EventArgs e)
        {
            if (Btn_post.Text == "發文")
            {
                Form1_ref.Form_Post.Show(Form1_ref);
                this.Hide();
            }
            else if (Btn_post.Text == "留言")
            {
                listBox1.SetSelected(0,true);
                string title=(string)listBox1.SelectedItem;
                Comment comment = new Comment(txt_comment.Text,Form1_ref.ID);
                Form1_ref.K_S.Request(KcardRequest.Add_Comment + title + '/' +comment.ToString());
                txt_comment.Clear();
                addpost(Form1_ref.K_S.Request(KcardRequest.Search_Article + title));
            }
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            if (Btn_post.Text == "發文")
            {
                if (MessageBox.Show("確認登出？", "登出", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Form1_ref.Form_Login.Show(Form1_ref);
                    this.Hide();
                }
            }
            else if (Btn_post.Text == "留言")
            {
                Btn_post.Text = "發文";
                Btn_Back.Text = "登出";
                listBox1.Items.Clear();
                addhome();
                txt_comment.Clear();
                txt_comment.Visible = false;
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            if (Btn_post.Text == "發文")
                addhome();
            else if (Btn_post.Text == "留言")
            {
                addpost(Form1_ref.K_S.Request(KcardRequest.Search_Article + title));
            }
                
        }

        public void addhome()
        {
            listBox1.Items.Clear();
            int i = 0;
            List<string> Re=new List<string>();
            while (true)
            {
                if (Form1_ref.K_S.Request(KcardRequest.List_Article + Convert.ToString(i)) == "null")
                    break;
                Re.Add(Form1_ref.K_S.Request(KcardRequest.List_Article + Convert.ToString(i)));
                i++;
            }
            i = 0;
            Re.Add("-------------------------------------------------------------------");
            while (true)
            {
                if (Form1_ref.K_S.Request(KcardRequest.List_Article_Top + Convert.ToString(i)) == "null")
                    break;
                Re.Add(Form1_ref.K_S.Request(KcardRequest.List_Article_Top + Convert.ToString(i)));
                i++;
            }
            Re.Add("置頂文章-----------------------------------------------------------------");
            for (i = Re.Count - 1; i >= 0;i-- )
                listBox1.Items.Add(Re[i]);
        }

        public void addpost(string longstr)
        {
            Article article = new Article(longstr);
            //MessageBox.Show("1\n" + article.Text + "\n2");
            txt_comment.Visible = true;
            Btn_post.Text = "留言";
            Btn_Back.Text = "返回";
            listBox1.Items.Clear();
            //listBox1.Items.Add("標題："+article.Title);
            listBox1.Items.Add(article.Title);
            listBox1.Items.Add("發文者：" + article.Writer);
            listBox1.Items.Add(article.first_Date);
            listBox1.Items.Add("文章內容：");
            int next = 0;
            string str = article.Text;
            while ((next = str.IndexOf("\n")) != -1)
            {
                if (next == -1)
                    break;
                listBox1.Items.Add(str.Remove(next));
                str = str.Substring(next + 1);
                next = 0;
            }
            listBox1.Items.Add(str);
            listBox1.Items.Add("----------------------");
            foreach(Comment comment in article.comment){
                listBox1.Items.Add(comment.Writer+"："+comment.Text+"  "+comment.first_Date);
            }
        }

        private void txt_comment_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Enter:
                    Btn_post.PerformClick();
                    break;
                default:
                    break;
            }
        }
    }
}
