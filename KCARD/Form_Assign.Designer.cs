namespace KCARD
{
    partial class Form_Assign
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
            this.RBtn_Student = new System.Windows.Forms.RadioButton();
            this.RBtn_Teacher = new System.Windows.Forms.RadioButton();
            this.RBtn_Worker = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lab_ID = new System.Windows.Forms.Label();
            this.lab_password = new System.Windows.Forms.Label();
            this.lab_checkpassword = new System.Windows.Forms.Label();
            this.txt_peopleID = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_checkpassword = new System.Windows.Forms.TextBox();
            this.Btn_assign = new System.Windows.Forms.Button();
            this.Btn_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RBtn_Student
            // 
            this.RBtn_Student.AutoSize = true;
            this.RBtn_Student.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RBtn_Student.Location = new System.Drawing.Point(18, 69);
            this.RBtn_Student.Name = "RBtn_Student";
            this.RBtn_Student.Size = new System.Drawing.Size(60, 25);
            this.RBtn_Student.TabIndex = 0;
            this.RBtn_Student.TabStop = true;
            this.RBtn_Student.Text = "學生";
            this.RBtn_Student.UseVisualStyleBackColor = true;
            // 
            // RBtn_Teacher
            // 
            this.RBtn_Teacher.AutoSize = true;
            this.RBtn_Teacher.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RBtn_Teacher.Location = new System.Drawing.Point(98, 69);
            this.RBtn_Teacher.Name = "RBtn_Teacher";
            this.RBtn_Teacher.Size = new System.Drawing.Size(60, 25);
            this.RBtn_Teacher.TabIndex = 1;
            this.RBtn_Teacher.TabStop = true;
            this.RBtn_Teacher.Text = "教授";
            this.RBtn_Teacher.UseVisualStyleBackColor = true;
            // 
            // RBtn_Worker
            // 
            this.RBtn_Worker.AutoSize = true;
            this.RBtn_Worker.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RBtn_Worker.Location = new System.Drawing.Point(178, 69);
            this.RBtn_Worker.Name = "RBtn_Worker";
            this.RBtn_Worker.Size = new System.Drawing.Size(92, 25);
            this.RBtn_Worker.TabIndex = 2;
            this.RBtn_Worker.TabStop = true;
            this.RBtn_Worker.Text = "行政人員";
            this.RBtn_Worker.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "身分";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::KCARD.Properties.Resources.kcardback;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 466);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(16, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "身份證字號";
            // 
            // lab_ID
            // 
            this.lab_ID.AutoSize = true;
            this.lab_ID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_ID.Location = new System.Drawing.Point(64, 166);
            this.lab_ID.Name = "lab_ID";
            this.lab_ID.Size = new System.Drawing.Size(42, 21);
            this.lab_ID.TabIndex = 6;
            this.lab_ID.Text = "暱稱";
            // 
            // lab_password
            // 
            this.lab_password.AutoSize = true;
            this.lab_password.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_password.Location = new System.Drawing.Point(64, 206);
            this.lab_password.Name = "lab_password";
            this.lab_password.Size = new System.Drawing.Size(42, 21);
            this.lab_password.TabIndex = 7;
            this.lab_password.Text = "密碼";
            // 
            // lab_checkpassword
            // 
            this.lab_checkpassword.AutoSize = true;
            this.lab_checkpassword.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_checkpassword.Location = new System.Drawing.Point(32, 256);
            this.lab_checkpassword.Name = "lab_checkpassword";
            this.lab_checkpassword.Size = new System.Drawing.Size(74, 21);
            this.lab_checkpassword.TabIndex = 8;
            this.lab_checkpassword.Text = "確認密碼";
            // 
            // txt_peopleID
            // 
            this.txt_peopleID.Location = new System.Drawing.Point(147, 125);
            this.txt_peopleID.Name = "txt_peopleID";
            this.txt_peopleID.Size = new System.Drawing.Size(100, 22);
            this.txt_peopleID.TabIndex = 9;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(147, 165);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 22);
            this.txt_ID.TabIndex = 10;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(147, 205);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(100, 22);
            this.txt_password.TabIndex = 11;
            // 
            // txt_checkpassword
            // 
            this.txt_checkpassword.Location = new System.Drawing.Point(147, 255);
            this.txt_checkpassword.Name = "txt_checkpassword";
            this.txt_checkpassword.Size = new System.Drawing.Size(100, 22);
            this.txt_checkpassword.TabIndex = 12;
            // 
            // Btn_assign
            // 
            this.Btn_assign.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_assign.Location = new System.Drawing.Point(18, 374);
            this.Btn_assign.Name = "Btn_assign";
            this.Btn_assign.Size = new System.Drawing.Size(100, 50);
            this.Btn_assign.TabIndex = 13;
            this.Btn_assign.Text = "註冊";
            this.Btn_assign.UseVisualStyleBackColor = true;
            this.Btn_assign.Click += new System.EventHandler(this.Btn_assign_Click);
            // 
            // Btn_Back
            // 
            this.Btn_Back.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_Back.Location = new System.Drawing.Point(147, 374);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(100, 50);
            this.Btn_Back.TabIndex = 14;
            this.Btn_Back.Text = "返回";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // Form_Assign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 461);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Btn_assign);
            this.Controls.Add(this.txt_checkpassword);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.txt_peopleID);
            this.Controls.Add(this.lab_checkpassword);
            this.Controls.Add(this.lab_password);
            this.Controls.Add(this.lab_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RBtn_Worker);
            this.Controls.Add(this.RBtn_Teacher);
            this.Controls.Add(this.RBtn_Student);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_Assign";
            this.Text = "註冊";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Assign_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RBtn_Student;
        private System.Windows.Forms.RadioButton RBtn_Teacher;
        private System.Windows.Forms.RadioButton RBtn_Worker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab_ID;
        private System.Windows.Forms.Label lab_password;
        private System.Windows.Forms.Label lab_checkpassword;
        private System.Windows.Forms.TextBox txt_peopleID;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_checkpassword;
        private System.Windows.Forms.Button Btn_assign;
        private System.Windows.Forms.Button Btn_Back;
    }
}