namespace Taxi_Project
{
    partial class Odeme
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
            label1 = new Label();
            lbl_tutar = new Label();
            btn_odeme_1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(329, 34);
            label1.Name = "label1";
            label1.Size = new Size(62, 30);
            label1.TabIndex = 0;
            label1.Text = "Tutar";
            // 
            // lbl_tutar
            // 
            lbl_tutar.AutoSize = true;
            lbl_tutar.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl_tutar.Location = new Point(329, 119);
            lbl_tutar.Name = "lbl_tutar";
            lbl_tutar.Size = new Size(62, 30);
            lbl_tutar.TabIndex = 1;
            lbl_tutar.Text = "Tutar";
            // 
            // btn_odeme_1
            // 
            btn_odeme_1.BackColor = SystemColors.ActiveCaption;
            btn_odeme_1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_odeme_1.Location = new Point(313, 196);
            btn_odeme_1.Name = "btn_odeme_1";
            btn_odeme_1.Size = new Size(107, 61);
            btn_odeme_1.TabIndex = 2;
            btn_odeme_1.Text = "ÖDE";
            btn_odeme_1.UseVisualStyleBackColor = false;
            btn_odeme_1.Click += btn_odeme_1_Click;
            // 
            // Odeme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_odeme_1);
            Controls.Add(lbl_tutar);
            Controls.Add(label1);
            Name = "Odeme";
            Text = "Odeme";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl_tutar;
        private Button btn_odeme_1;
    }
}