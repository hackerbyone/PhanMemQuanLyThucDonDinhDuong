using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Phần_Mềm_Dinh_Dưỡng.All_User_Control
{
    public partial class UC_TaoThucDonTheoMau : UserControl
    {
        public UC_TaoThucDonTheoMau()
        {
            InitializeComponent();
        }

        private void UC_TaoThucDonTheoMau_Load(object sender, EventArgs e)
        {
            LoadNhomTre();
        }

        void LoadNhomTre()
        {
            string query = "SELECT DISTINCT NhomTre FROM ThucDon";
            DataTable dt = GetData(query);
            cbNhomTre.DataSource = dt;
            cbNhomTre.DisplayMember = "NhomTre";
            cbNhomTre.ValueMember = "NhomTre";
        }

        void LoadTenThucDon(string nhomTre)
        {
            string query = "SELECT DISTINCT TenThucDon FROM ThucDon WHERE NhomTre = @NhomTre";
            DataTable dt = GetData(query, new SqlParameter("@NhomTre", nhomTre));
            cbTenThucDon.DataSource = dt;
            cbTenThucDon.DisplayMember = "TenThucDon";
            cbTenThucDon.ValueMember = "TenThucDon";
        }

        void LoadThucDon(string nhomTre, string tenThucDon)
        {
            string query = "SELECT * FROM ThucDon WHERE NhomTre = @NhomTre AND TenThucDon = @TenThucDon";
            DataTable dt = GetData(query,
                new SqlParameter("@NhomTre", nhomTre),
                new SqlParameter("@TenThucDon", tenThucDon)
            );
            dgvThucDon.DataSource = dt;
        }

        private DataTable GetData(string query, params SqlParameter[] parameters)
        {
            string connectionString = "Data Source=.;Initial Catalog=Thực đơn dinh dưỡng;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        private void cbNhomTre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNhomTre.SelectedValue != null)
            {
                string nhomTre = cbNhomTre.SelectedValue.ToString();
                LoadTenThucDon(nhomTre);
            }
        }

        private void cbTenThucDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNhomTre.SelectedValue != null && cbTenThucDon.SelectedValue != null)
            {
                string nhomTre = cbNhomTre.SelectedValue.ToString();
                string tenThucDon = cbTenThucDon.SelectedValue.ToString();
                LoadThucDon(nhomTre, tenThucDon);
            }
        }
    }
}
