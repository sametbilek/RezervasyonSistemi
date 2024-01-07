using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using RezervasyonSistemi;

namespace RezervasyonSistemi
{
    public partial class FormAdmin : Form
    {
        private List<Company> CompanyList;
        public FormAdmin(List<Company> companyList)
        {
            InitializeComponent();
            this.CompanyList = companyList;
        }

        public FormAdmin()
        {
            throw new NotImplementedException();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            dataGridView1.ColumnCount = 1;
            dataGridView1.Columns[0].HeaderText = "Firmalar";

            foreach (Company company in CompanyList)
            {
                dataGridView1.Rows.Add(company.CompanyName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string companyName = textBox1.Text;

            if (string.IsNullOrWhiteSpace(companyName))
            {
                MessageBox.Show("Firma adı boş bırakılamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Company newCompany = new Company {CompanyName = companyName, Username = companyName, Password = "123" };
                CompanyList.Add(newCompany);

                MessageBox.Show("Firma kaydı başarıyla yapılmıştır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
               
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;

            
                CompanyList.RemoveAt(selectedRowIndex);

                MessageBox.Show("Firma kaydı başarıyla silinmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen bir firma seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin(CompanyList);
            formLogin.Show();
            this.Hide();
        }
    }
}