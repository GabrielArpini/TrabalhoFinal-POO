using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFinanceiro
{
    public partial class MainMenuForms : Form
    {
        private Financeiros financeiros;
        public MainMenuForms(string username)
        {
            InitializeComponent();
            financeiros = new Financeiros();
            financeiros.Carregar(username);
            lblUsernameMain.Text = username;
            double somaIncome = 0;
            double somaExpenses = 0;
            foreach(var e in financeiros.ListarTodos())
            {
                somaIncome += e.Income;
                somaExpenses -= e.Expenses;
            }
            lblGanhosApp.Text = somaIncome.ToString();
            lblGastosApp.Text = somaExpenses.ToString();
            lblSaldoApp.Text = (somaIncome + somaExpenses).ToString();
        }

        private void lblSaldoApp_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ImgLogoApp_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_MouseCaptureChanged(object sender, EventArgs e)
        {
            
        }
       

        private void btn2Main_Click(object sender, EventArgs e)
        {
            
        }

        private void btn2Main_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void dashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void btn3Main_Click(object sender, EventArgs e)
        {
            gerenciarForms gerenciarForms = new gerenciarForms(this.lblUsernameMain.Text);
            this.Hide();
            gerenciarForms.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormConfig formConfig = new FormConfig(this.lblUsernameMain.Text);
            this.Hide();
            formConfig.ShowDialog();
        }
    }
}
