namespace BaiTapNhom
{
    partial class frmThemCauHoi
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbChuDoiMau = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdConservation = new System.Windows.Forms.RadioButton();
            this.rdIncomplete = new System.Windows.Forms.RadioButton();
            this.rdTEST1 = new System.Windows.Forms.RadioButton();
            this.btThemCauHoi = new System.Windows.Forms.Button();
            this.pnMutiple = new System.Windows.Forms.Panel();
            this.richDapAnDungMutiple = new System.Windows.Forms.RichTextBox();
            this.richDapAnMutiple = new System.Windows.Forms.RichTextBox();
            this.txtNoidungMutiple = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnMutiple.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lbChuDoiMau);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btThemCauHoi);
            this.panel1.Controls.Add(this.pnMutiple);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 574);
            this.panel1.TabIndex = 0;
            // 
            // lbChuDoiMau
            // 
            this.lbChuDoiMau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbChuDoiMau.BackColor = System.Drawing.Color.Transparent;
            this.lbChuDoiMau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChuDoiMau.ForeColor = System.Drawing.Color.Red;
            this.lbChuDoiMau.Location = new System.Drawing.Point(28, 334);
            this.lbChuDoiMau.Name = "lbChuDoiMau";
            this.lbChuDoiMau.Size = new System.Drawing.Size(201, 47);
            this.lbChuDoiMau.TabIndex = 4;
            this.lbChuDoiMau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(14, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 182);
            this.panel2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.rdConservation);
            this.groupBox1.Controls.Add(this.rdIncomplete);
            this.groupBox1.Controls.Add(this.rdTEST1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chon Loai Cau Hoi:";
            // 
            // rdConservation
            // 
            this.rdConservation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdConservation.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdConservation.AutoSize = true;
            this.rdConservation.Location = new System.Drawing.Point(28, 112);
            this.rdConservation.Name = "rdConservation";
            this.rdConservation.Size = new System.Drawing.Size(161, 35);
            this.rdConservation.TabIndex = 2;
            this.rdConservation.TabStop = true;
            this.rdConservation.Text = "Conservation";
            this.rdConservation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdConservation.UseVisualStyleBackColor = true;
            this.rdConservation.CheckedChanged += new System.EventHandler(this.rdConservation_CheckedChanged);
            // 
            // rdIncomplete
            // 
            this.rdIncomplete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdIncomplete.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdIncomplete.Location = new System.Drawing.Point(28, 71);
            this.rdIncomplete.Name = "rdIncomplete";
            this.rdIncomplete.Size = new System.Drawing.Size(161, 35);
            this.rdIncomplete.TabIndex = 2;
            this.rdIncomplete.TabStop = true;
            this.rdIncomplete.Text = "Incomplete";
            this.rdIncomplete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdIncomplete.UseVisualStyleBackColor = true;
            this.rdIncomplete.CheckedChanged += new System.EventHandler(this.rdIncomplete_CheckedChanged);
            // 
            // rdTEST1
            // 
            this.rdTEST1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdTEST1.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdTEST1.Location = new System.Drawing.Point(28, 30);
            this.rdTEST1.Name = "rdTEST1";
            this.rdTEST1.Size = new System.Drawing.Size(161, 35);
            this.rdTEST1.TabIndex = 1;
            this.rdTEST1.TabStop = true;
            this.rdTEST1.Text = "Mutiple";
            this.rdTEST1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdTEST1.UseVisualStyleBackColor = true;
            this.rdTEST1.CheckedChanged += new System.EventHandler(this.rdTEST1_CheckedChanged);
            // 
            // btThemCauHoi
            // 
            this.btThemCauHoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btThemCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemCauHoi.Location = new System.Drawing.Point(45, 261);
            this.btThemCauHoi.Name = "btThemCauHoi";
            this.btThemCauHoi.Size = new System.Drawing.Size(161, 43);
            this.btThemCauHoi.TabIndex = 2;
            this.btThemCauHoi.Text = "Xong";
            this.btThemCauHoi.UseVisualStyleBackColor = true;
            this.btThemCauHoi.Click += new System.EventHandler(this.btThemCauHoi_Click);
            // 
            // pnMutiple
            // 
            this.pnMutiple.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMutiple.Controls.Add(this.richDapAnDungMutiple);
            this.pnMutiple.Controls.Add(this.richDapAnMutiple);
            this.pnMutiple.Controls.Add(this.txtNoidungMutiple);
            this.pnMutiple.Controls.Add(this.label3);
            this.pnMutiple.Controls.Add(this.label2);
            this.pnMutiple.Controls.Add(this.label1);
            this.pnMutiple.Location = new System.Drawing.Point(263, 13);
            this.pnMutiple.Name = "pnMutiple";
            this.pnMutiple.Size = new System.Drawing.Size(640, 546);
            this.pnMutiple.TabIndex = 1;
            // 
            // richDapAnDungMutiple
            // 
            this.richDapAnDungMutiple.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richDapAnDungMutiple.Location = new System.Drawing.Point(7, 386);
            this.richDapAnDungMutiple.Name = "richDapAnDungMutiple";
            this.richDapAnDungMutiple.Size = new System.Drawing.Size(630, 157);
            this.richDapAnDungMutiple.TabIndex = 3;
            this.richDapAnDungMutiple.Text = "";
            // 
            // richDapAnMutiple
            // 
            this.richDapAnMutiple.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richDapAnMutiple.Location = new System.Drawing.Point(92, 206);
            this.richDapAnMutiple.Name = "richDapAnMutiple";
            this.richDapAnMutiple.Size = new System.Drawing.Size(545, 154);
            this.richDapAnMutiple.TabIndex = 2;
            this.richDapAnMutiple.Text = "";
            // 
            // txtNoidungMutiple
            // 
            this.txtNoidungMutiple.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNoidungMutiple.Location = new System.Drawing.Point(92, 21);
            this.txtNoidungMutiple.Multiline = true;
            this.txtNoidungMutiple.Name = "txtNoidungMutiple";
            this.txtNoidungMutiple.Size = new System.Drawing.Size(544, 179);
            this.txtNoidungMutiple.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dap An Dung:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dap An:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Noi dung:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmThemCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 570);
            this.Controls.Add(this.panel1);
            this.Name = "frmThemCauHoi";
            this.Text = "frmThemCauHoi";
            this.Load += new System.EventHandler(this.frmThemCauHoi_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnMutiple.ResumeLayout(false);
            this.pnMutiple.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdConservation;
        private System.Windows.Forms.RadioButton rdIncomplete;
        private System.Windows.Forms.RadioButton rdTEST1;
        private System.Windows.Forms.Button btThemCauHoi;
        private System.Windows.Forms.Panel pnMutiple;
        private System.Windows.Forms.RichTextBox richDapAnDungMutiple;
        private System.Windows.Forms.RichTextBox richDapAnMutiple;
        private System.Windows.Forms.TextBox txtNoidungMutiple;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbChuDoiMau;
        private System.Windows.Forms.Timer timer1;
    }
}