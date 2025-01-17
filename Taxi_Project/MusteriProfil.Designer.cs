namespace Taxi_Project
{
    partial class MusteriProfil
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
            lbl_name = new Label();
            lbl_tc = new Label();
            lbl_il = new Label();
            lbl_semt = new Label();
            lbl_ilce = new Label();
            lbl_mah = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmb_ilce_1 = new ComboBox();
            cmb_semt_1 = new ComboBox();
            cmb_mahalle_1 = new ComboBox();
            btn_odeme = new Button();
            lbl_id = new Label();
            SuspendLayout();
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl_name.Location = new Point(534, 44);
            lbl_name.Margin = new Padding(4, 0, 4, 0);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(31, 21);
            lbl_name.TabIndex = 0;
            lbl_name.Text = "Ad";
            // 
            // lbl_tc
            // 
            lbl_tc.AutoSize = true;
            lbl_tc.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl_tc.Location = new Point(853, 44);
            lbl_tc.Margin = new Padding(4, 0, 4, 0);
            lbl_tc.Name = "lbl_tc";
            lbl_tc.Size = new Size(28, 21);
            lbl_tc.TabIndex = 1;
            lbl_tc.Text = "TC";
            // 
            // lbl_il
            // 
            lbl_il.AutoSize = true;
            lbl_il.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl_il.Location = new Point(88, 159);
            lbl_il.Margin = new Padding(4, 0, 4, 0);
            lbl_il.Name = "lbl_il";
            lbl_il.Size = new Size(19, 21);
            lbl_il.TabIndex = 2;
            lbl_il.Text = "İl";
            // 
            // lbl_semt
            // 
            lbl_semt.AutoSize = true;
            lbl_semt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl_semt.Location = new Point(641, 159);
            lbl_semt.Margin = new Padding(4, 0, 4, 0);
            lbl_semt.Name = "lbl_semt";
            lbl_semt.Size = new Size(48, 21);
            lbl_semt.TabIndex = 3;
            lbl_semt.Text = "Semt";
            // 
            // lbl_ilce
            // 
            lbl_ilce.AutoSize = true;
            lbl_ilce.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl_ilce.Location = new Point(349, 159);
            lbl_ilce.Margin = new Padding(4, 0, 4, 0);
            lbl_ilce.Name = "lbl_ilce";
            lbl_ilce.Size = new Size(36, 21);
            lbl_ilce.TabIndex = 4;
            lbl_ilce.Text = "İlce";
            // 
            // lbl_mah
            // 
            lbl_mah.AutoSize = true;
            lbl_mah.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl_mah.Location = new Point(853, 159);
            lbl_mah.Margin = new Padding(4, 0, 4, 0);
            lbl_mah.Name = "lbl_mah";
            lbl_mah.Size = new Size(67, 21);
            lbl_mah.TabIndex = 5;
            lbl_mah.Text = "Mahalle";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 338);
            label1.Name = "label1";
            label1.Size = new Size(192, 21);
            label1.TabIndex = 6;
            label1.Text = "GİTMEK İSTEDİĞİNİZ YER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(395, 387);
            label2.Name = "label2";
            label2.Size = new Size(36, 21);
            label2.TabIndex = 7;
            label2.Text = "İlçe";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(395, 439);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 8;
            label3.Text = "Semt";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(386, 499);
            label4.Name = "label4";
            label4.Size = new Size(67, 21);
            label4.TabIndex = 9;
            label4.Text = "Mahalle";
            // 
            // cmb_ilce_1
            // 
            cmb_ilce_1.FormattingEnabled = true;
            cmb_ilce_1.Location = new Point(511, 387);
            cmb_ilce_1.Name = "cmb_ilce_1";
            cmb_ilce_1.Size = new Size(302, 29);
            cmb_ilce_1.TabIndex = 10;
            cmb_ilce_1.SelectedIndexChanged += cmb_ilce_1_SelectedIndexChanged;
            // 
            // cmb_semt_1
            // 
            cmb_semt_1.FormattingEnabled = true;
            cmb_semt_1.Location = new Point(511, 439);
            cmb_semt_1.Name = "cmb_semt_1";
            cmb_semt_1.Size = new Size(302, 29);
            cmb_semt_1.TabIndex = 11;
            cmb_semt_1.SelectedIndexChanged += cmb_semt_1_SelectedIndexChanged;
            // 
            // cmb_mahalle_1
            // 
            cmb_mahalle_1.FormattingEnabled = true;
            cmb_mahalle_1.Location = new Point(511, 499);
            cmb_mahalle_1.Name = "cmb_mahalle_1";
            cmb_mahalle_1.Size = new Size(302, 29);
            cmb_mahalle_1.TabIndex = 12;
            // 
            // btn_odeme
            // 
            btn_odeme.BackColor = SystemColors.ActiveCaption;
            btn_odeme.Location = new Point(928, 457);
            btn_odeme.Name = "btn_odeme";
            btn_odeme.Size = new Size(148, 71);
            btn_odeme.TabIndex = 15;
            btn_odeme.Text = "ÖDEME YAP";
            btn_odeme.UseVisualStyleBackColor = false;
            btn_odeme.Click += btn_odeme_Click;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl_id.Location = new Point(122, 44);
            lbl_id.Margin = new Padding(4, 0, 4, 0);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(25, 21);
            lbl_id.TabIndex = 16;
            lbl_id.Text = "Id";
            // 
            // MusteriProfil
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1265, 630);
            Controls.Add(lbl_id);
            Controls.Add(btn_odeme);
            Controls.Add(cmb_mahalle_1);
            Controls.Add(cmb_semt_1);
            Controls.Add(cmb_ilce_1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl_mah);
            Controls.Add(lbl_ilce);
            Controls.Add(lbl_semt);
            Controls.Add(lbl_il);
            Controls.Add(lbl_tc);
            Controls.Add(lbl_name);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "MusteriProfil";
            Text = "MusteriProfil";
            Shown += MusteriProfil_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_name;
        private Label lbl_tc;
        private Label lbl_il;
        private Label lbl_semt;
        private Label lbl_ilce;
        private Label lbl_mah;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmb_ilce_1;
        private ComboBox cmb_semt_1;
        private ComboBox cmb_mahalle_1;
        private Button btn_odeme;
        private Label lbl_id;
    }
}