namespace BaiTapNhom
{
    partial class frmDanhSachHocVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhSachHocVien));
            this.pnDanhSachHocVien = new System.Windows.Forms.Panel();
            this.listViewHocVien = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tztTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnDanhSachHocVien.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDanhSachHocVien
            // 
            this.pnDanhSachHocVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnDanhSachHocVien.Controls.Add(this.panel2);
            this.pnDanhSachHocVien.Controls.Add(this.panel1);
            this.pnDanhSachHocVien.Location = new System.Drawing.Point(0, 0);
            this.pnDanhSachHocVien.Name = "pnDanhSachHocVien";
            this.pnDanhSachHocVien.Size = new System.Drawing.Size(561, 264);
            this.pnDanhSachHocVien.TabIndex = 0;
            // 
            // listViewHocVien
            // 
            this.listViewHocVien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewHocVien.HideSelection = false;
            this.listViewHocVien.Location = new System.Drawing.Point(0, 0);
            this.listViewHocVien.Name = "listViewHocVien";
            this.listViewHocVien.Size = new System.Drawing.Size(561, 212);
            this.listViewHocVien.SmallImageList = this.imageList1;
            this.listViewHocVien.TabIndex = 0;
            this.listViewHocVien.UseCompatibleStateImageBehavior = false;
            this.listViewHocVien.View = System.Windows.Forms.View.Details;
            this.listViewHocVien.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewHocVien_ColumnClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cabbage_vegetables_vegetable_food_agriculture_icon_220781.ico");
            this.imageList1.Images.SetKeyName(1, "tomato_vegetables_vegetable_food_agriculture_fruit_icon_220780.ico");
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tztTimKiem);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 48);
            this.panel1.TabIndex = 1;
            // 
            // tztTimKiem
            // 
            this.tztTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tztTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tztTimKiem.Location = new System.Drawing.Point(118, 12);
            this.tztTimKiem.Name = "tztTimKiem";
            this.tztTimKiem.Size = new System.Drawing.Size(324, 31);
            this.tztTimKiem.TabIndex = 0;
            this.tztTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tztTimKiem.TextChanged += new System.EventHandler(this.tztTimKiem_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tim Kiem:";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.listViewHocVien);
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(561, 215);
            this.panel2.TabIndex = 2;
            // 
            // frmDanhSachHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 264);
            this.Controls.Add(this.pnDanhSachHocVien);
            this.Name = "frmDanhSachHocVien";
            this.Text = "frmDanhSachHocVien";
            this.Load += new System.EventHandler(this.frmDanhSachHocVien_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDanhSachHocVien_KeyDown);
            this.pnDanhSachHocVien.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnDanhSachHocVien;
        private System.Windows.Forms.ListView listViewHocVien;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tztTimKiem;
        private System.Windows.Forms.Panel panel2;
    }
}