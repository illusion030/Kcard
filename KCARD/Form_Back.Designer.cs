namespace KCARD
{
    partial class Form_Back
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_post = new System.Windows.Forms.Button();
            this.Btn_Account = new System.Windows.Forms.Button();
            this.Btn_Hurry = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.Btn_do = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KCARD.Properties.Resources.kcardback;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(497, 577);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_post
            // 
            this.Btn_post.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_post.Location = new System.Drawing.Point(24, 34);
            this.Btn_post.Name = "Btn_post";
            this.Btn_post.Size = new System.Drawing.Size(84, 32);
            this.Btn_post.TabIndex = 1;
            this.Btn_post.Text = "管理文章";
            this.Btn_post.UseVisualStyleBackColor = true;
            this.Btn_post.Click += new System.EventHandler(this.Btn_post_Click);
            // 
            // Btn_Account
            // 
            this.Btn_Account.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_Account.Location = new System.Drawing.Point(24, 79);
            this.Btn_Account.Name = "Btn_Account";
            this.Btn_Account.Size = new System.Drawing.Size(84, 32);
            this.Btn_Account.TabIndex = 2;
            this.Btn_Account.Text = "管理帳號";
            this.Btn_Account.UseVisualStyleBackColor = true;
            this.Btn_Account.Click += new System.EventHandler(this.Btn_Account_Click);
            // 
            // Btn_Hurry
            // 
            this.Btn_Hurry.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_Hurry.Location = new System.Drawing.Point(24, 124);
            this.Btn_Hurry.Name = "Btn_Hurry";
            this.Btn_Hurry.Size = new System.Drawing.Size(84, 32);
            this.Btn_Hurry.TabIndex = 3;
            this.Btn_Hurry.Text = "緊急貼文";
            this.Btn_Hurry.UseVisualStyleBackColor = true;
            this.Btn_Hurry.Click += new System.EventHandler(this.Btn_Hurry_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(125, -1);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(357, 550);
            this.listBox1.TabIndex = 4;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // Btn_Back
            // 
            this.Btn_Back.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_Back.Location = new System.Drawing.Point(24, 228);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(84, 38);
            this.Btn_Back.TabIndex = 5;
            this.Btn_Back.Text = "返回";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // Btn_do
            // 
            this.Btn_do.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_do.Location = new System.Drawing.Point(24, 184);
            this.Btn_do.Name = "Btn_do";
            this.Btn_do.Size = new System.Drawing.Size(84, 38);
            this.Btn_do.TabIndex = 6;
            this.Btn_do.Text = "刪除";
            this.Btn_do.UseVisualStyleBackColor = true;
            this.Btn_do.Click += new System.EventHandler(this.Btn_do_Click);
            // 
            // Form_Back
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.Btn_do);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Btn_Hurry);
            this.Controls.Add(this.Btn_Account);
            this.Controls.Add(this.Btn_post);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_Back";
            this.Text = "後台";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Back_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_post;
        private System.Windows.Forms.Button Btn_Account;
        private System.Windows.Forms.Button Btn_Hurry;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Button Btn_do;
    }
}