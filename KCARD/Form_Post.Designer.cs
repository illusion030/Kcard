namespace KCARD
{
    partial class Form_Post
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
            this.txt_topic = new System.Windows.Forms.TextBox();
            this.txt_inside = new System.Windows.Forms.RichTextBox();
            this.lab_topic = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Post = new System.Windows.Forms.Button();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.CBox_Hurry = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KCARD.Properties.Resources.kcardback;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 478);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txt_topic
            // 
            this.txt_topic.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_topic.Location = new System.Drawing.Point(28, 47);
            this.txt_topic.Name = "txt_topic";
            this.txt_topic.Size = new System.Drawing.Size(231, 29);
            this.txt_topic.TabIndex = 1;
            // 
            // txt_inside
            // 
            this.txt_inside.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_inside.Location = new System.Drawing.Point(30, 115);
            this.txt_inside.Name = "txt_inside";
            this.txt_inside.Size = new System.Drawing.Size(229, 250);
            this.txt_inside.TabIndex = 2;
            this.txt_inside.Text = "";
            // 
            // lab_topic
            // 
            this.lab_topic.AutoSize = true;
            this.lab_topic.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_topic.Location = new System.Drawing.Point(26, 21);
            this.lab_topic.Name = "lab_topic";
            this.lab_topic.Size = new System.Drawing.Size(42, 21);
            this.lab_topic.TabIndex = 3;
            this.lab_topic.Text = "標題";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(28, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "內容";
            // 
            // Btn_Post
            // 
            this.Btn_Post.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_Post.Location = new System.Drawing.Point(84, 409);
            this.Btn_Post.Name = "Btn_Post";
            this.Btn_Post.Size = new System.Drawing.Size(75, 40);
            this.Btn_Post.TabIndex = 5;
            this.Btn_Post.Text = "發文";
            this.Btn_Post.UseVisualStyleBackColor = true;
            this.Btn_Post.Click += new System.EventHandler(this.Btn_Post_Click);
            // 
            // Btn_Back
            // 
            this.Btn_Back.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_Back.Location = new System.Drawing.Point(184, 409);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(75, 40);
            this.Btn_Back.TabIndex = 6;
            this.Btn_Back.Text = "返回";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // CBox_Hurry
            // 
            this.CBox_Hurry.AutoSize = true;
            this.CBox_Hurry.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CBox_Hurry.Location = new System.Drawing.Point(30, 378);
            this.CBox_Hurry.Name = "CBox_Hurry";
            this.CBox_Hurry.Size = new System.Drawing.Size(93, 25);
            this.CBox_Hurry.TabIndex = 7;
            this.CBox_Hurry.Text = "緊急貼文";
            this.CBox_Hurry.UseVisualStyleBackColor = true;
            // 
            // Form_Post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 461);
            this.Controls.Add(this.CBox_Hurry);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Btn_Post);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lab_topic);
            this.Controls.Add(this.txt_inside);
            this.Controls.Add(this.txt_topic);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_Post";
            this.Text = "發文";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Post_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_topic;
        private System.Windows.Forms.RichTextBox txt_inside;
        private System.Windows.Forms.Label lab_topic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Post;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.CheckBox CBox_Hurry;
    }
}