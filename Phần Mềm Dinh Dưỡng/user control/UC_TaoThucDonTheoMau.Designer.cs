namespace Phần_Mềm_Dinh_Dưỡng.All_User_Control
{
    partial class UC_TaoThucDonTheoMau
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNhomTre = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbTenThucDon = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvThucDon = new System.Windows.Forms.DataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(246, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn nhóm trẻ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(1026, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn thực đơn";
            // 
            // cbNhomTre
            // 
            this.cbNhomTre.BackColor = System.Drawing.Color.Transparent;
            this.cbNhomTre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbNhomTre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNhomTre.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbNhomTre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbNhomTre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbNhomTre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbNhomTre.ItemHeight = 30;
            this.cbNhomTre.Location = new System.Drawing.Point(466, 77);
            this.cbNhomTre.Name = "cbNhomTre";
            this.cbNhomTre.Size = new System.Drawing.Size(226, 36);
            this.cbNhomTre.TabIndex = 5;
            this.cbNhomTre.SelectedIndexChanged += new System.EventHandler(this.cbNhomTre_SelectedIndexChanged);
            // 
            // cbTenThucDon
            // 
            this.cbTenThucDon.BackColor = System.Drawing.Color.Transparent;
            this.cbTenThucDon.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTenThucDon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenThucDon.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTenThucDon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTenThucDon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTenThucDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbTenThucDon.ItemHeight = 30;
            this.cbTenThucDon.Items.AddRange(new object[] {
            "Thực đơn nhóm nhà trẻ 1",
            "Thực đơn nhóm mẫu giáo 1"});
            this.cbTenThucDon.Location = new System.Drawing.Point(1243, 77);
            this.cbTenThucDon.Name = "cbTenThucDon";
            this.cbTenThucDon.Size = new System.Drawing.Size(308, 36);
            this.cbTenThucDon.TabIndex = 6;
            this.cbTenThucDon.SelectedIndexChanged += new System.EventHandler(this.cbTenThucDon_SelectedIndexChanged);
            // 
            // dgvThucDon
            // 
            this.dgvThucDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvThucDon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThucDon.Location = new System.Drawing.Point(131, 153);
            this.dgvThucDon.Name = "dgvThucDon";
            this.dgvThucDon.RowHeadersWidth = 51;
            this.dgvThucDon.RowTemplate.Height = 24;
            this.dgvThucDon.Size = new System.Drawing.Size(1700, 600);
            this.dgvThucDon.TabIndex = 7;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_TaoThucDonTheoMau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvThucDon);
            this.Controls.Add(this.cbTenThucDon);
            this.Controls.Add(this.cbNhomTre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_TaoThucDonTheoMau";
            this.Size = new System.Drawing.Size(1882, 852);
            this.Load += new System.EventHandler(this.UC_TaoThucDonTheoMau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbNhomTre;
        private Guna.UI2.WinForms.Guna2ComboBox cbTenThucDon;
        private System.Windows.Forms.DataGridView dgvThucDon;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
