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
    public partial class WindowCreateProject : Form
    {
        private WindowCreateProject()
        {
            InitializeComponent();
        }
        private static WindowCreateProject instance;
        public static WindowCreateProject GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new WindowCreateProject();
            }

            return instance;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtName.Text.Length > 0) 
            {
                Project P = new Project();
                P.Name = txtName.Text;
                P.StartDate = dtpStart.Value.Date;
                P.ExpectedFinishDate = dtpEnd.Value.Date;
                
                ProjectRepository.Save(P);
                MessageBox.Show("Projeto Adicionado!");
                txtName.Text = "";
            }
            else
            {
                MessageBox.Show("Insira um nome", "Erro");
            }
        }
    }
}
