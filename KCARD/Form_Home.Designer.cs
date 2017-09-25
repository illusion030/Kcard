namespace KCARD
{
    partial class Form_Home
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Btn_post = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.txt_comment = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(124, -1);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(357, 529);
            this.listBox1.TabIndex = 0;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // Btn_post
            // 
            this.Btn_post.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_post.Location = new System.Drawing.Point(25, 24);
            this.Btn_post.Name = "Btn_post";
            this.Btn_post.Size = new System.Drawing.Size(75, 72);
            this.Btn_post.TabIndex = 2;
            this.Btn_post.Text = "發文";
            this.Btn_post.UseVisualStyleBackColor = true;
            this.Btn_post.Click += new System.EventHandler(this.Btn_post_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KCARD.Properties.Resources.kcardback;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(491, 571);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Back
            // 
            this.Btn_Back.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_Back.Location = new System.Drawing.Point(25, 102);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(75, 34);
            this.Btn_Back.TabIndex = 3;
            this.Btn_Back.Text = "返回";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // txt_comment
            // 
            this.txt_comment.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_comment.Location = new System.Drawing.Point(124, 527);
            this.txt_comment.Name = "txt_comment";
            this.txt_comment.Size = new System.Drawing.Size(357, 29);
            this.txt_comment.TabIndex = 4;
            this.txt_comment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_comment_KeyDown);
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_reset.Location = new System.Drawing.Point(25, 492);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(93, 36);
            this.btn_reset.TabIndex = 5;
            this.btn_reset.Text = "重新整理";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // Form_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.txt_comment);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Btn_post);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_Home";
            this.Text = "首頁";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Home_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_post;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.TextBox txt_comment;
        private System.Windows.Forms.Button btn_reset;


    }
}