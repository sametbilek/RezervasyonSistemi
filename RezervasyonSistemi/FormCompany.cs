using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RezervasyonSistemi
{
    public partial class FormCompany : Form
    {
        private CompanyManager companyManager;
        private List<Company> CompanyList;

        public FormCompany(List<Company> companyList)
        {
            InitializeComponent();
            CompanyList = companyList;
            companyManager = new CompanyManager();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            dataGridView1.ColumnCount = 1;
            dataGridView1.Columns[0].HeaderText = "Araçlar";
        }

        private void FormCompany_Load(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin(CompanyList);
            formLogin.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            dataGridView1.Rows.Clear();

            string selectedCompanyName = label3.Text;

            foreach (var vehicle in companyManager.CompanyVehicles)
            {
                if (!vehicle.IsDeleted && vehicle.companyName.Equals(selectedCompanyName))
                {
                    dataGridView1.Rows.Add(vehicle.araçId);
                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string companyName = label3.Text;
            string vehicleName = textBox1.Text;

            if (string.IsNullOrWhiteSpace(vehicleName))
            {
                MessageBox.Show("Araç adı boş bırakılamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!vehicleName.Contains(companyName))
                {
                    vehicleName = companyName + vehicleName;
                }

                companyManager.AddVehicle(companyName, vehicleName);

                MessageBox.Show("Araç kaydı başarıyla yapılmıştır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                UpdateDataGridView();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;

                string selectedVehicleId = dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString();

                companyManager.RemoveVehicle(selectedVehicleId);

                MessageBox.Show("Araç kaydı başarıyla silinmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateDataGridView();
            }
            else
            {
                MessageBox.Show("Lütfen bir araç seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
