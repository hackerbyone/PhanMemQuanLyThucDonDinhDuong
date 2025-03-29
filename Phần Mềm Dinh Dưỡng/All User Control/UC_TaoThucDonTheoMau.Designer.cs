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
            this.cboNhomTre = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboTenThucDon = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ColorTransition1 = new Guna.UI2.WinForms.Guna2ColorTransition(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(81, 70);
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
            this.label2.Location = new System.Drawing.Point(866, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn thực đơn";
            // 
            // cboNhomTre
            // 
            this.cboNhomTre.BackColor = System.Drawing.Color.Transparent;
            this.cboNhomTre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNhomTre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhomTre.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboNhomTre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboNhomTre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboNhomTre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboNhomTre.ItemHeight = 30;
            this.cboNhomTre.Location = new System.Drawing.Point(235, 53);
            this.cboNhomTre.Name = "cboNhomTre";
            this.cboNhomTre.Size = new System.Drawing.Size(178, 36);
            this.cboNhomTre.TabIndex = 2;
            // 
            // cboTenThucDon
            // 
            this.cboTenThucDon.BackColor = System.Drawing.Color.Transparent;
            this.cboTenThucDon.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTenThucDon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTenThucDon.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTenThucDon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTenThucDon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTenThucDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboTenThucDon.ItemHeight = 30;
            this.cboTenThucDon.Location = new System.Drawing.Point(1046, 54);
            this.cboTenThucDon.Name = "cboTenThucDon";
            this.cboTenThucDon.Size = new System.Drawing.Size(178, 36);
            this.cboTenThucDon.TabIndex = 3;
            this.cboTenThucDon.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox2_SelectedIndexChanged);
            // 
            // guna2ColorTransition1
            // 
            this.guna2ColorTransition1.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Orange};
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(312, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // UC_TaoThucDonTheoMau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cboTenThucDon);
            this.Controls.Add(this.cboNhomTre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_TaoThucDonTheoMau";
            this.Size = new System.Drawing.Size(1882, 852);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cboNhomTre;
        private Guna.UI2.WinForms.Guna2ComboBox cboTenThucDon;
        private Guna.UI2.WinForms.Guna2ColorTransition guna2ColorTransition1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
