using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Kcard_class;

namespace KCARD
{
    public partial class Form1 : Form
    {

        public Form_Login Form_Login;
        public Form_Assign Form_Assign;
        public Form_Home Form_Home;
        public Form_Back Form_Back;
        public Form_Post Form_Post;
        public Boolean close = false;
        public string ID = "";
        public string who = "";
        public Socket Kcard_Server;
        public Kcard_Socket K_S;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
                K_S.Close();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            string ip = txt_IP.Text;
            K_S.Get_Server_ip(ip);
            if (K_S.Open() == 1)
            {
                Form_Login = new Form_Login(this);
                Form_Assign = new Form_Assign(this);
                Form_Home = new Form_Home(this);
                Form_Back = new Form_Back(this);
                Form_Post = new Form_Post(this);
                Form_Login.Show(this);
                this.Hide();
            }
            else
            {
                txt_IP.Clear();
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            K_S = new Kcard_Socket("Client");
            if (K_S.Server_ip != "")
            {
                if (K_S.Open() == 1)
                {
                    Form_Login = new Form_Login(this);
                    Form_Assign = new Form_Assign(this);
                    Form_Home = new Form_Home(this);
                    Form_Back = new Form_Back(this);
                    Form_Post = new Form_Post(this);
                    Form_Login.Show(this);
                    this.Hide();
                }
            }
        }
    }
}
