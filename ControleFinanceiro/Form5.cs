using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ControleFinanceiro
{
    public partial class gerenciarForms : Form
    {
        private Financeiros financeiros;

        public gerenciarForms(string user)
        {
            InitializeComponent();
            lblUsernameMain.Text = user;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index >= 0)
                {
                    int index = dataGridView1.CurrentRow.Index;
                    List<Financeiro> fin = financeiros.ListarTodos();
                    fin.RemoveAt(index);
                    financeiros.Atualizar(fin);
                    financeiros.Salvar(lblUsernameMain.Text);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = financeiros.ListarTodos();
                }
                else
                {
                    MessageBox.Show("Nenhuma linha está selecionada.");
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Não há um item para ser deletado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Financeiro n = new Financeiro()
                {
                    Name = txtBoxNameGerenciar.Text,
                    Categoria = txtBoxCateGerenciar.Text,
                    Income = double.Parse(txtBoxIncomeGerenciar.Text),
                    Expenses = double.Parse(txtBoxExpensesGerenciar.Text),
                    Date = DateTime.Parse(txtBoxDataGerenciar.Text),
                };
                financeiros.Adicionar(n);
                financeiros.Salvar(lblUsernameMain.Text);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = financeiros.ListarTodos();
                btnAtualizarGerenciar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gerenciarForms_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn3Main_Click(object sender, EventArgs e)
        {
        }

        private void btn1Main_Click(object sender, EventArgs e)
        {
            MainMenuForms mainMenuForms = new MainMenuForms(this.lblUsernameMain.Text);
            this.Hide();
            mainMenuForms.Show();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index >= 0)
                {
                    txtBoxNameGerenciar.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    txtBoxCateGerenciar.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    txtBoxIncomeGerenciar.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    txtBoxExpensesGerenciar.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    txtBoxDataGerenciar.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Financeiro f = new Financeiro();
                f.Name = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                f.Categoria = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                f.Income = double.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                f.Expenses = double.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                f.Date = DateTime.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());

                financeiros.Adicionar(f);
                financeiros.Salvar(lblUsernameMain.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar célula: " + ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void gerenciarForms_Load(object sender, EventArgs e)
        {
            financeiros = new Financeiros();
            financeiros.Carregar(lblUsernameMain.Text);
            List<Financeiro> bind = new List<Financeiro>(financeiros.ListarTodos());
            dataGridView1.DataSource = bind;
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string Nome = txtBoxPesquisaGerenciar.Text;
            txtBoxPesquisaGerenciar.Text = "";

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == Nome)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index >= 0)
                {
                    int index = dataGridView1.CurrentRow.Index;
                    List<Financeiro> fin = financeiros.ListarTodos();
                    Financeiro f = fin[index];
                    f.Name = txtBoxNameGerenciar.Text;
                    f.Categoria = txtBoxCateGerenciar.Text;
                    f.Income = double.Parse(txtBoxIncomeGerenciar.Text);
                    f.Expenses = double.Parse(txtBoxExpensesGerenciar.Text);
                    f.Date = DateTime.Parse(txtBoxDataGerenciar.Text);
                    financeiros.Atualizar(fin);
                    financeiros.Salvar(lblUsernameMain.Text);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = financeiros.ListarTodos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormConfig formConfig = new FormConfig(this.lblUsernameMain.Text);
            this.Hide();
            formConfig.ShowDialog();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Erro nos dados: " + e.Exception.Message);
        }
    }
}
