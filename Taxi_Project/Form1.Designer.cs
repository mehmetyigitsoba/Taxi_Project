namespace Taxi_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            txt_TC = new TextBox();
            txt_password = new TextBox();
            pictureBox1 = new PictureBox();
            btn_login1 = new Button();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(106, 69);
            label1.Name = "label1";
            label1.Size = new Size(32, 21);
            label1.TabIndex = 0;
            label1.Text = "TC:";
            
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(106, 125);
            label2.Name = "label2";
            label2.Size = new Size(48, 21);
            label2.TabIndex = 1;
            label2.Text = "Şifre:";
            // 
            // txt_TC
            // 
            txt_TC.Location = new Point(250, 74);
            txt_TC.Name = "txt_TC";
            txt_TC.Size = new Size(242, 23);
            txt_TC.TabIndex = 2;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(250, 127);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(242, 23);
            txt_password.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(521, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btn_login1
            // 
            btn_login1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_login1.Location = new Point(273, 165);
            btn_login1.Name = "btn_login1";
            btn_login1.Size = new Size(169, 44);
            btn_login1.TabIndex = 5;
            btn_login1.Text = "GİRİŞ YAP";
            btn_login1.UseVisualStyleBackColor = true;
            btn_login1.Click += btn_login1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(51, 185);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(46, 15);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Kayıt ol";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 234);
            Controls.Add(linkLabel1);
            Controls.Add(btn_login1);
            Controls.Add(pictureBox1);
            Controls.Add(txt_password);
            Controls.Add(txt_TC);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_TC;
        private TextBox txt_password;
        private PictureBox pictureBox1;
        private Button btn_login1;
        private LinkLabel linkLabel1;
    }
}
