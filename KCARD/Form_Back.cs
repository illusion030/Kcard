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
    public partial class Form_Back : Form
    {
        Boolean post = true;
        Boolean top = false;
        Form1 Form1_ref;
        public Form_Back(Form1 Temp)
        {
            InitializeComponent();
            Form1_ref = Temp;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            Btn_do.Visible = false;
            Btn_do.Enabled = false;
        }
        private void Form_Back_FormClosing(object sender, FormClosingEventArgs e)
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
            if (Btn_post.Visible == false)
            {
                if (top)
                {
                    Btn_post.Visible = true;
                    Btn_Hurry.Visible = true;
                    Btn_do.Visible = true;
                    Btn_Account.Visible = true;
                    listBox1.Items.Clear();
                    int i = 0;
                    string Re;
                    while ((Re = Form1_ref.K_S.Request(KcardRequest.List_Article_Top + Convert.ToString(i))) != "null")
                    {
                        listBox1.Items.Add(Re);
                        i++;
                    }
                    i = 0;
                    while ((Re = Form1_ref.K_S.Request(KcardRequest.List_Article + Convert.ToString(i))) != "null")
                    {
                        string str = Form1_ref.K_S.Request(KcardRequest.Search_Article + Re);
                        Article article = new Article(str);
                        if (article.Top == true)
                            listBox1.Items.Add(article.Title);
                        i++;
                    }
                }
                else
                {
                    Btn_post.Visible = true;
                    Btn_Hurry.Visible = true;
                    Btn_do.Visible = true;
                    Btn_Account.Visible = true;
                    addpost();
                }
                
            }
            else
            {
                if (MessageBox.Show("確認返回？", "返回", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Form1_ref.Form_Login.Show(Form1_ref);
                    Btn_do.Visible = false;
                    Btn_do.Enabled = false;
                    listBox1.Items.Clear();
                    this.Hide();
                }
            }
            
        }

        private void Btn_post_Click(object sender, EventArgs e)
        {
            Btn_do.Visible = true;
            Btn_do.Enabled = true;
            Btn_do.Text = "刪除";
            post = true;
            top = false;
            addpost();
        }

        private void Btn_Account_Click(object sender, EventArgs e)
        {
            string Re;
            int i = 0;
            post = false;
            top = false;
            Btn_do.Visible = true;
            Btn_do.Enabled = true;
            Btn_do.Text = "刪除";
            listBox1.Items.Clear();
            while ((Re = Form1_ref.K_S.Request(KcardRequest.List_User + Convert.ToString(i)))!="null")
            {
                listBox1.Items.Add(Re);
                i++;
            }
        }

        private void Btn_Hurry_Click(object sender, EventArgs e)
        {
            Btn_do.Visible = true;
            Btn_do.Enabled = true;
            Btn_do.Text = "置頂";
            top = true;
            listBox1.Items.Clear();
            int i=0;
            string Re;
            while ((Re = Form1_ref.K_S.Request(KcardRequest.List_Article_Top + Convert.ToString(i))) != "null")
            {
                listBox1.Items.Add(Re);
                i++;
            }
            i = 0;
            while((Re=Form1_ref.K_S.Request(KcardRequest.List_Article+Convert.ToString(i)))!="null")
            {
                string str = Form1_ref.K_S.Request(KcardRequest.Search_Article + Re);
                Article article = new Article(str);
                if (article.Top == true)
                    listBox1.Items.Add(article.Title);
                i++;
            }
        }

        private void Btn_do_Click(object sender, EventArgs e)
        {
            if(Btn_do.Text=="刪除")
            {
                if (listBox1.SelectedIndex!=-1)
                {
                    if (post)
                    {
                        if ((string)listBox1.SelectedItem != "-------------------------------------------------------------------" && (string)listBox1.SelectedItem != "置頂文章-----------------------------------------------------------------")
                        {
                            if (MessageBox.Show("確認刪除文章：" + (string)listBox1.SelectedItem + "？", "刪除文章", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                Form1_ref.K_S.Request(KcardRequest.Delete_Article + (string)listBox1.SelectedItem);
                                addpost();
                            }
                        }
                    }
                    else if (!post)
                    {
                        if (MessageBox.Show("確認刪除帳號：" + (string)listBox1.SelectedItem + "？", "刪除帳號", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int i = 0;
                            string Re;
                            Form1_ref.K_S.Request(KcardRequest.Delete_User + (string)listBox1.SelectedItem);
                            listBox1.Items.Clear();
                            while ((Re = Form1_ref.K_S.Request(KcardRequest.List_User + Convert.ToString(i))) != "null")
                            {
                                listBox1.Items.Add(Re);
                                i++;
                            }
                        }
                    }
                }
            }
            else if (Btn_do.Text == "置頂")
            {
                Form1_ref.K_S.Request(KcardRequest.Change_Top + (string)listBox1.SelectedItem);
                topornot();
            }
            else if (Btn_do.Text == "取消置頂")
            {
                Form1_ref.K_S.Request(KcardRequest.Change_Top + (string)listBox1.SelectedItem);
                topornot();
            }
               
            
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            topornot();
        }

        public void addpost()
        {
            listBox1.Items.Clear();
            int i = 0;
            List<string> Re = new List<string>();
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
            for (i = Re.Count - 1; i >= 0; i--)
                listBox1.Items.Add(Re[i]);
        }

        public void topornot()
        {
            if (top)
            {
                int i = 0;
                string Re;
                Boolean find = false;
                while ((Re = Form1_ref.K_S.Request(KcardRequest.List_Article + Convert.ToString(i))) != "null")
                {
                    if (Re == (string)listBox1.SelectedItem)
                        find = true;
                    i++;
                }
                if (find)
                    Btn_do.Text = "置頂";
                else
                    Btn_do.Text = "取消置頂";
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if ((post||top) && (string)listBox1.SelectedItem != null&&Btn_post.Visible==true)
            {
                if ((string)listBox1.SelectedItem != "-------------------------------------------------------------------" && (string)listBox1.SelectedItem != "置頂文章-----------------------------------------------------------------")
                {
                    string longstr = Form1_ref.K_S.Request(KcardRequest.Search_Article + (string)listBox1.SelectedItem);
                    Article article = new Article(longstr);
                    Btn_Account.Visible = false;
                    Btn_do.Visible = false;
                    Btn_Hurry.Visible = false;
                    Btn_post.Visible = false;
                    listBox1.Items.Clear();
                    //listBox1.Items.Add("標題："+article.Title);
                    listBox1.Items.Add(article.Title);
                    listBox1.Items.Add("發文者：" + article.Writer);
                    listBox1.Items.Add(article.first_Date);
                    listBox1.Items.Add("文章內容：");
                    int next = 0;
                    string str = article.Text;
                    while ((next = str.IndexOf("\n")) != 0)
                    {
                        if (next == -1)
                            break;
                        listBox1.Items.Add(str.Remove(next));
                        str = str.Substring(next + 1);
                        next = 0;
                    }
                    listBox1.Items.Add(str);
                    listBox1.Items.Add("----------------------");
                    foreach (Comment comment in article.comment)
                    {
                        listBox1.Items.Add(comment.Writer + "：" + comment.Text + "  " + comment.first_Date);
                    }
                }
            }
        }
    }
}
