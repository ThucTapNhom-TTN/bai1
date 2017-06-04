namespace QLNS.Add
{
    partial class AddBoPhan
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
            this.label1 = new System.Windows.Forms.Label();
            this.maBPTB = new System.Windows.Forms.TextBox();
            this.tenBPTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ghiChu = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã bộ phận (*):";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // maBPTB
            // 
            this.maBPTB.Location = new System.Drawing.Point(102, 23);
            this.maBPTB.Name = "maBPTB";
            this.maBPTB.Size = new System.Drawing.Size(263, 20);
            this.maBPTB.TabIndex = 1;
            this.maBPTB.TextChanged += new System.EventHandler(this.maBPTB_TextChanged);
            // 
            // tenBPTB
            // 
            this.tenBPTB.Location = new System.Drawing.Point(102, 62);
            this.tenBPTB.Name = "tenBPTB";
            this.tenBPTB.Size = new System.Drawing.Size(263, 20);
            this.tenBPTB.TabIndex = 3;
            this.tenBPTB.TextChanged += new System.EventHandler(this.tenBPTB_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên bộ phận (*):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ghi chú:";
            // 
            // ghiChu
            // 
            this.ghiChu.Location = new System.Drawing.Point(102, 105);
            this.ghiChu.Multiline = true;
            this.ghiChu.Name = "ghiChu";
            this.ghiChu.Size = new System.Drawing.Size(263, 58);
            this.ghiChu.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(275, 205);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 38);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(139, 205);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 38);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddBoPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 292);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.ghiChu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tenBPTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maBPTB);
            this.Controls.Add(this.label1);
            this.Name = "AddBoPhan";
            this.Text = "AddBoPhan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maBPTB;
        private System.Windows.Forms.TextBox tenBPTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ghiChu;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}