using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoDesenvolvedores
{
    public partial class WindowLogIn : Form
    {
        private WindowLogIn()
        {
            InitializeComponent();
        }
        private static WindowLogIn instance;
        public static WindowLogIn GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new WindowLogIn();
            }

            return instance;
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Developer devLog = CredentialRepository.Auth(txbEmail.Text, txbSenha.Text);
            if (devLog == null)
            {
                MessageBox.Show("Email ou senha incorretos!", "Erro");
            }
            else if (devLog.Credential.IsActive)
            {
                txbEmail.Text = "";
                txbSenha.Text = "";
                WindowHome.GetInstance(devLog).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Developer inativo. \nEntre em contato com o Administrador para ativar sua conta.", "Erro");
            }
        }
        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            GestaoDesenvolvedores.WindowMenu.GetInstance().Show();
        }

        private void tsmBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tsmBack.PerformClick();
            }
        }

        private void txbEmail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txbSenha.Focus();
            }
        }
    }
}
