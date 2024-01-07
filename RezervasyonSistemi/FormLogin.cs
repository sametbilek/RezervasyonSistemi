using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using RezervasyonSistemi;



namespace RezervasyonSistemi
{
    public partial class FormLogin : Form
    {

        private List<Company> CompanyList;
        private RouteManager routeManager;

        public FormLogin(List<Company> companyList)
        {
            InitializeComponent();
            CompanyList = companyList;
            routeManager = new RouteManager();
        }


        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormUser user = new FormUser(routeManager);
            user.Show();
            this.Hide();    
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin adminn = new Admin();
           

            if(textBoxKaA.Text.Equals("") || textBoxSa.Text.Equals(""))
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş geçilemez.", "Uyarı!");
            }
            else
            {
                if(textBoxKaA.Text.Equals(adminn.Username) && textBoxSa.Text.Equals(adminn.Password))
                {
                    FormAdmin formadmin = new FormAdmin(CompanyList);
                    formadmin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış.", "Uyarı");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            bool isCredentialsValid = false;

            if (textBoxKaF.Text.Equals("") || textBoxSf.Text.Equals(""))
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş geçilemez.", "Uyarı!");
            }
            else
            {
                foreach (Company company in CompanyList)
                {
                    if (company.Login(textBoxKaF.Text, textBoxSf.Text))
                    {

                        FormCompany formCompany = new FormCompany(CompanyList);
                        formCompany.Show();
                        this.Hide();
                        formCompany.label3.Text = textBoxKaF.Text;
                        isCredentialsValid = true;
                        break;
                    }
                }

                if (!isCredentialsValid)
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış.", "Uyarı");
                }
            }
        }
    }
}
