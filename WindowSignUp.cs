using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace GestaoDesenvolvedores
{
    internal partial class WindowSignUp : Form
    {
        private WindowSignUp(List<Level> levels)
        {
            InitializeComponent();
            dtpDBdayDate.Value = DateTime.Now;
            cbxLevel.DataSource = levels;
        }
        private static WindowSignUp instance;
        public static WindowSignUp GetInstance(List<Level> levels)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new WindowSignUp(levels);
            }

            return instance;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SingUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            GestaoDesenvolvedores.WindowMenu.GetInstance().Show();
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSingUp_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Insira um nome!", "Erro");
                txtName.Focus();
                return; // Para a execução do método aqui e não roda as próximas linhas
            }
            try
            {
                MailAddress mail = new MailAddress(txtEmail.Text);
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Erro");
                txtEmail.Focus();
                return;
            }
            if (((txtPassword.Text.Length >= 8) && (txtPassword.Text.Length <= 12)) == false)
            {
                MessageBox.Show("A senha deve conter entre 8 e 12 caracteres.", "Erro");
                txtPassword.Focus();
                return;
            }
            if (cbxLevel.SelectedIndex < 0)
            {
                MessageBox.Show("Um nível é necessario para o cadastro.\n Caso tenha dúvida sobre eu nível, constate o Administrador.", "Erro");
                cbxLevel.Focus();
                return;
            }
            if(dtpDBdayDate.Value >= DateTime.Now)
            {
                MessageBox.Show("Insira uma data válida!", "Erro");
                dtpDBdayDate.Focus();
                return;
            }
            Developer newDev = new Developer(txtName.Text, dtpDBdayDate.Value.Date, LevelsRepository.GetLevel((Level) cbxLevel.SelectedItem));

            Credential newDevCredential = new Credential(txtEmail.Text, txtPassword.Text, newDev);
            newDev.Credential = newDevCredential;

            if (!DeveloperRepository.Check(newDev))
            {
                DeveloperRepository.Save(newDev);
            }
            else 
            { 
                MessageBox.Show("Este email já existe!", "Erro");
                return;
            }
            MessageBox.Show("Aguarde o Administrador ativar sua conta e faça o log In", "Sucesso!");
            this.Close();


        }

        private void txtLogo_Click(object sender, EventArgs e)
        {

        }

        private void tsmBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus();
            }
        }

        private void txtEmail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tsmBack.PerformClick();
            }
        }

        private void cbxLevel_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
